


using ERDCodeFirst.Domains;
using Microsoft.EntityFrameworkCore;
namespace ERDCodeFirst.Infrastructure
{
  
    public class ApplicationDbContext : DbContext
    {
            public ApplicationDbContext(DbContextOptions options) : base(options) { }


        //public DbSet<User> Users { get; set; }
        //public DbSet<Department> Departments { get; set; }  
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<BookAuthors> BookAuthors { get; set; }
        public DbSet<BookCategories> BookCategories { get; set; }
        public DbSet<BookDetails> BookDetails { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookAuthors>()
                .HasKey(ba => new { ba.BookID, ba.AuthorID });
            modelBuilder.Entity<BookCategories>()
                .HasKey(bc => new { bc.BookID, bc.CategoryID });

            modelBuilder.Entity<OrderItems>()
               .HasKey(oi => new { oi.OrderID, oi.BookID });

            modelBuilder.Entity<Reviews>()
               .HasKey(r => new { r.BookID, r.CustomerID });
        }

    }
}
