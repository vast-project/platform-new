namespace Platform.Data
{
    public interface IDataRepository
    {
        //Listing methods
        List<Article> GetArticles(string query, string tag=null);
        List<Article> GetResources(string query);
        List<Article> GetGames(string query);
        List<Article> GetServices(string query);

        //Individual records
        Article GetArticle(string id);
    }
}
