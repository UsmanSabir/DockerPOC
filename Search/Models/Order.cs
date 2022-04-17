namespace Search.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItem> OrderItems{ get; set; }
    }
}
