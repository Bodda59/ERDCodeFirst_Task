namespace ERDCodeFirst.Domains
{
    public class Orders
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }

    }
}
