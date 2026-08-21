namespace ERDCodeFirst.Domains
{
    public class BookCategories
    {
        public int BookID { get; set; }
        public Books Books { get; set; }
        public int CategoryID { get; set; }
        public Categories Categories { get; set; }
    }
}
