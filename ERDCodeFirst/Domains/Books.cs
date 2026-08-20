namespace ERDCodeFirst.Domains
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal price { get; set; }
        public DateOnly PublicationDate { get; set; }
        public int PublisherID { get; set; }
    }
}
