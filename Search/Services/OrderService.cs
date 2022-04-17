using Search.Contracts;
using Search.Models;
using System.Text.Json;

namespace Search.Services
{
    public class OrderService : IOrderService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<OrderService> _logger;

        public OrderService(IHttpClientFactory httpClientFactory, ILogger<OrderService> logger)
        {
            this._httpClientFactory = httpClientFactory;
            this._logger = logger;
        }

        public async Task<(bool IsSuccess, IEnumerable<Order> Orders, string Message)> GetOrderAsync(int customerId)
        {
            try
            {
                var client = _httpClientFactory.CreateClient("OrdersService");
                var response = await client.GetAsync($"orders/GetByCustomerId/{customerId}");
                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                    var result = JsonSerializer.Deserialize<IEnumerable<Order>>(body, options);

                    return (true, result, string.Empty);
                }
                return (false, null, response.ReasonPhrase);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex.ToString());
                return (false, null, ex.Message);                
            }
        }
    }
}
