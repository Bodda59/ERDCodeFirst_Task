using System.Text.Json.Serialization;

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
        public Publishers Publishers { get; set; }

        
        public BookDetails BookDetails { get; set; } 
        public List<BookAuthors> BookAuthors { get; set; } = new List<BookAuthors>();
        public List<BookCategories> BookCategories { get; set; }= new List<BookCategories>();
        public List<Reviews> Reviews { get; set; }=new List<Reviews>();
        public List<OrderItems> OrderItems { get; set; } =new List<OrderItems>();

    }
}
