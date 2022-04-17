using Search.Contracts;
using Search.Models;

namespace Search.Services
{
    public class SearchService : ISearchService
    {
        private readonly IOrderService _orderService;

        public SearchService(IOrderService orderService)
        {
            this._orderService = orderService;
        }

        public async Task<SearchResult> Search(SearchModel search)
        {
            var result = await _orderService.GetOrderAsync(search.CustomerId);
            if (result.IsSuccess)
            {
                return new SearchResult
                {
                    IsSuccess = true,
                    Result = result.Orders.ToList(),
                };
            }

            return new SearchResult
            {
                IsSuccess = false,
                Result = null,
                Message = result.Message
            };
        }
    }
}
