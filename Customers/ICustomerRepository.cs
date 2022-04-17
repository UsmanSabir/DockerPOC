namespace Customers
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        Customer GetById(int id);
    }
}