namespace ERDCodeFirst.Domains
{
    public class OrderItems
    {
        public int BookID { get; set; }
        public Books Books { get; set; }
        public int OrderID { get; set; }
        public Orders Orders { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
