namespace Orders
{
    public interface IOrdersRepository
    {
        List<Order> GetAll();

        Order GetById(int id);
        List<Order> GetByCustomerId(int customerId);
    }
}