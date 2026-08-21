using System.Text.Json.Serialization;

namespace ERDCodeFirst.Domains
{
    public class BookDetails
    {
        public int BookId { get; set; }
        public Books Books { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }


    }
}
