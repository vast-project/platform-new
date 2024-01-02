using Microsoft.AspNetCore.Mvc;
using Platform.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IDataRepository _dataRepository;

        public ArticlesController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET api/<ArticleController>/5
        [HttpGet("{id}")]
        public ActionResult<Article> Get(string id)
        {
            return Ok(_dataRepository.GetArticle(id));
        }

    }
}
