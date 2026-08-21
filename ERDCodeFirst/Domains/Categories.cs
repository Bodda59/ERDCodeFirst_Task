namespace ERDCodeFirst.Domains
{
    public class Categories
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<BookCategories>  BookCategories { get; set; } = new List<BookCategories>();

    }
}
