using Search.Models;

namespace Search.Contracts
{
    public interface IProductsService
    {
        Task<(bool IsSuccess, IEnumerable<Product> Products, string Message)> GetProductAsync();
    }
}