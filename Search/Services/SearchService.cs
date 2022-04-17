using Search.Contracts;
using Search.Models;

namespace Search.Services
{
    public class SearchService : ISearchService
    {
        private readonly IOrderService _orderService;
        private readonly IProductsService _productsService;

        public SearchService(IOrderService orderService, IProductsService productsService)
        {
            this._orderService = orderService;
            this._productsService = productsService;
        }

        public async Task<SearchResult> Search(SearchModel search)
        {
            var result = await _orderService.GetOrderAsync(search.CustomerId);
            var productsResult = await _productsService.GetProductAsync();

            if (result.IsSuccess)
            {
                var orders = result.Orders.ToList();
                orders.ForEach(o =>
                {
                    o.OrderItems.ForEach(oItem =>
                    {
                        oItem.Name = productsResult.Products?.FirstOrDefault(p => p.Id == oItem.Id)?.Name??"Product(s) missing";
                    });
                });
                return new SearchResult
                {
                    IsSuccess = true,
                    Result = orders,
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
