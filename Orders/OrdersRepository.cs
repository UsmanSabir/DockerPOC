namespace Orders
{
    public class OrdersRepository : IOrdersRepository
    {
        List<Order> _orders = new List<Order>();

        public OrdersRepository()
        {
            for (int i = 0; i < 10; i++)
                _orders.Add(new Order() { Id = i, CustomerId = i, OrderDate=DateTime.Now, Products= new List<int>() { i } });
        }

        public List<Order> GetAll()
        {
            return _orders.ToList();
        }

        public List<Order> GetByCustomerId(int customerId) => _orders.Where(p => p.CustomerId == customerId).ToList();
       

        public Order GetById(int id) => _orders.FirstOrDefault(p => p.CustomerId == id);
    }

    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<int>? Products { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
