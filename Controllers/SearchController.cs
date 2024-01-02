using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Platform.Data;

namespace Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private IDataRepository _dataRepository;

        private SearchListing ConvertToSearchListings<T>(T objectToConvert)
        {
            SearchListing result = null;
            //Convert the games to SearchListings
            if (objectToConvert is Article article)
            {
                result = new SearchListing
                {
                    Id = article.Id,
                    Title = article.Title,
                    Description = article.Description,
                    Tag = "Article",
                    Url = "/present/article/" + article.Slug
                };

                if (article.Tags != null && article.Tags.Count > 0)
                {
                    result.Tag = article.Tags[0];
                    //Make sure the first letter is uppercase
                    result.Tag = result.Tag.Substring(0, 1).ToUpper() + result.Tag.Substring(1);
                }
            }

            return result;
        }

        private List<SearchListing> ConvertToSearchListings<T>(List<T> objectsList)
        {
            //Convert the games to SearchListings
            List<SearchListing> searchListings = new List<SearchListing>();
            foreach (var curObject in objectsList)
            {
                var converted = ConvertToSearchListings(curObject);
                if (converted != null)
                {
                    searchListings.Add(converted);
                }
            }

            return searchListings;
        }

        public SearchController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SearchListing>> Get(string query = "", string type = null)
        {
            switch (type)
            {
                case "games":
                    return Ok(ConvertToSearchListings(_dataRepository.GetGames(query)));
                    break;
                case "resources":
                    return Ok(ConvertToSearchListings(_dataRepository.GetResources(query)));
                    break;
                default:
                    return Ok(ConvertToSearchListings(_dataRepository.GetArticles(query, type)));
            }
        }

        [HttpGet("{id}")]
        public ActionResult<SearchListing> Get(string id)
        {
            var article = _dataRepository.GetArticle(id);
            if (article == null)
            {
                return NotFound();
            }

            //Convert to listing
            var listing = ConvertToSearchListings(article);
            if (listing == null)
            {
                return NotFound();
            }

            return listing;
        }
    }
}
