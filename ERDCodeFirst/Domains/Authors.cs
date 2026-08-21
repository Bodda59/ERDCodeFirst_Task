namespace ERDCodeFirst.Domains
{
    public class Authors
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BookAuthors> BookAuthors { get; set; } = new List<BookAuthors>();

    }
}
