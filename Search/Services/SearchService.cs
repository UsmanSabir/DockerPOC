using Search.Contracts;
using Search.Models;

namespace Search.Services
{
    public class SearchService : ISearchService
    {
        public SearchResult Search(SearchModel search)
        {
            return new SearchResult
            {
                IsSuccess = true,
                Result = search
            };
        }
    }
}
