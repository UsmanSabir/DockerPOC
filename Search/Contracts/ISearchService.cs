using Search.Models;

namespace Search.Contracts
{
    public interface ISearchService
    {
        SearchResult Search(SearchModel search);
    }
}