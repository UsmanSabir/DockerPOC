using Microsoft.AspNetCore.Mvc;

namespace Customers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly ICustomerRepository _customersRepository;

        public CustomersController(ILogger<CustomersController> logger,
            ICustomerRepository customersRepository)
        {
            _logger = logger;
            _customersRepository = customersRepository;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Customer> GetAll()
        {
            return _customersRepository.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public Customer GetById(int id)
        {
            return _customersRepository.GetById(id);
        }
    }
}