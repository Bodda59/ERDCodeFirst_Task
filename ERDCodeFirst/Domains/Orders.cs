namespace ERDCodeFirst.Domains
{
    public class Orders
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customers Customers { get; set; }
        public List<OrderItems> OrderItems { get; set; } = new List<OrderItems>();


    }
}
