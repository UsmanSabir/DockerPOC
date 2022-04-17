using Microsoft.AspNetCore.Mvc;

namespace Products.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductsRepository _productsRepository;

        public ProductsController(ILogger<ProductsController> logger, IProductsRepository productsRepository)
        {
            _logger = logger;
            this._productsRepository = productsRepository;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Product> GetAll()
        {
            return _productsRepository.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public Product GetById(int id)
        {
            return _productsRepository.GetById(id);
        }
    }
}