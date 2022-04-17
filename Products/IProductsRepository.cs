
namespace Products
{
    public interface IProductsRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
    }
}