namespace ERDCodeFirst.Domains
{
    public class OrderItems
    {
        public int BookID { get; set; }
        public int OrderID { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
