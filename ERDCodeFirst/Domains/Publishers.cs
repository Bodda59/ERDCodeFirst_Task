namespace ERDCodeFirst.Domains
{
    public class Publishers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public List<Books> Books { get; set; }  = new List<Books>();
    }
}
