using Search.Models;

namespace Search.Contracts
{
    public interface ISearchService
    {
        Task<SearchResult> Search(SearchModel search);
    }
}