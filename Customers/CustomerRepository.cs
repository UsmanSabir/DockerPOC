namespace Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        List<Customer> _customer = new List<Customer>();

        public CustomerRepository()
        {
            for (int i = 0; i < 10; i++)
                _customer.Add(new Customer() { Id = i, Name = $"C{i}"});
        }

        public List<Customer> GetAll()
        {
            return _customer.ToList();
        }

        public Customer GetById(int id) => _customer.FirstOrDefault(p => p.Id == id);
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }    

    }
}
