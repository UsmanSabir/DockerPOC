using Search.Models;
using System.Threading.Tasks;

namespace Search.Contracts
{
    public interface IOrderService
    {
        Task<(bool IsSuccess, IEnumerable<Order> Orders, string Message)> GetOrderAsync(int customerId);
    }
}
