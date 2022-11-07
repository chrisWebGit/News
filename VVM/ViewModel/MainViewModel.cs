using System;

namespace VVM.ViewModel
{
    internal class MainViewModel
    {
        public string ?ApiKey { get; set; }
        public string ?Keyword { get; set; }
        public string ?DateTime { get; set; }

        public MainViewModel() {  }

     /*   public NewsAPI.Models.ArticlesResult Search(DateTime dateTime, string keyword)
        {
            if (keyword == null)
            {
                NewsAPI.NewsApiClient newsApiClient = new NewsAPI.NewsApiClient(ApiKey);
                NewsAPI.Models.TopHeadlinesRequest topHeadlinesRequest = new NewsAPI.Models.TopHeadlinesRequest();
                NewsAPI.Models.ArticlesResult articlesResult = newsApiClient.GetTopHeadlines(topHeadlinesRequest);
                return articlesResult;
            } 
            else
            {
                NewsAPI.NewsApiClient newsApiClient = new NewsAPI.NewsApiClient(ApiKey);
                NewsAPI.Models.EverythingRequest everythingRequest = new NewsAPI.Models.EverythingRequest();
                everythingRequest.Q = keyword;
                everythingRequest.From = dateTime;
                NewsAPI.Models.ArticlesResult articlesResult = newsApiClient.GetEverything(everythingRequest);
                return articlesResult;
            }
        }*/
    }
}
