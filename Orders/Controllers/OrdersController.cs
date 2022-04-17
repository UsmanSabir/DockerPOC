using Microsoft.AspNetCore.Mvc;

namespace Orders.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IOrdersRepository _ordersRepository;

        public OrdersController(ILogger<OrdersController> logger,
            IOrdersRepository OrdersRepository)
        {
            _logger = logger;
            _ordersRepository = OrdersRepository;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Order> GetAll()
        {
            return _ordersRepository.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public Order GetById(int id)
        {
            return _ordersRepository.GetById(id);
        }

        [HttpGet("GetByCustomerId/{customerId}")]
        public List<Order> GetByCustomerId(int customerId)
        {
            return _ordersRepository.GetByCustomerId(customerId);
        }
    }
}