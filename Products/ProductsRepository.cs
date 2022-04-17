namespace Products
{
    public class ProductsRepository : IProductsRepository
    {
        List<Product> _products = new List<Product>();

        public ProductsRepository()
        {
            for (int i = 0; i < 10; i++)
                _products.Add(new Product() { Id = i, Name = $"P{i}", Price = 2 * i });
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public Product GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
