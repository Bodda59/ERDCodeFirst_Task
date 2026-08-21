using Microsoft.EntityFrameworkCore;

namespace ERDCodeFirst.Domains
{
    public class BookAuthors
    {

        public int BookID { get; set; }
        public Books books { get; set; }
        public int AuthorID { get; set; }
        public Authors authors { get; set; }

        


    }
}
