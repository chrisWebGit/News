namespace DataAccess
{
    internal class DataAccess_ArticlesResult
    {
        private System.Collections.Generic.Dictionary<DateTime, NewsAPI.Models.ArticlesResult> ArticlesResultList { get; set; }

        public DataAccess_ArticlesResult()
        {
           ArticlesResultList = new Dictionary<DateTime, NewsAPI.Models.ArticlesResult>();
        }

        public System.Collections.Generic.Dictionary<DateTime, NewsAPI.Models.ArticlesResult> GetArticlesResultList()
        {
            return ArticlesResultList;
        }

        public void Insert(DateTime dateTime, NewsAPI.Models.ArticlesResult articlesResult)
        {
            ArticlesResultList.Add(dateTime, articlesResult);
        }
    }
}