namespace ERDCodeFirst.Domains
{
    public class Reviews
    {
        public int BookID { get; set; }
        public Books Books { get; set; }    
        public int CustomerID { get; set; }
        public Customers Customers { get; set; }

        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateOnly ReviewDate { get; set; }
    }
}
