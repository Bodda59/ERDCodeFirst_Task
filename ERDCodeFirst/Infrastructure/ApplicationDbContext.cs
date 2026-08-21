


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
            modelBuilder.Entity<BookDetails>()
                .HasKey(bd => bd.BookId);

            modelBuilder.Entity<Books>()
                .HasOne(b => b.BookDetails)
                .WithOne(bd => bd.Books)
                .HasForeignKey<BookDetails>(bd => bd.BookId);

            modelBuilder.Entity<ShippingAddress>()
                .HasKey(bd => bd.CustomerId);
            modelBuilder.Entity<Customers>()
                .HasOne(b => b.ShippingAddress)
                .WithOne(bd => bd.Customers)
                .HasForeignKey<ShippingAddress>(bd => bd.CustomerId);

            modelBuilder.Entity<BookAuthors>()
                .HasKey(ba => new { ba.BookID, ba.AuthorID });

            // FK to Books
            modelBuilder.Entity<BookAuthors>()
                .HasOne(ba => ba.books)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookID);

            // FK to Authors
            modelBuilder.Entity<BookAuthors>()
                .HasOne(ba => ba.authors)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => ba.AuthorID);

            modelBuilder.Entity<BookCategories>()
               .HasKey(ba => new { ba.BookID, ba.CategoryID });

            // FK to Books
            modelBuilder.Entity<BookCategories>()
                .HasOne(ba => ba.Books)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(ba => ba.BookID);

            // FK to Categorie
            modelBuilder.Entity<BookCategories>()
                .HasOne(ba => ba.Categories)
                .WithMany(a => a.BookCategories)
                .HasForeignKey(ba => ba.CategoryID);

            modelBuilder.Entity<Reviews>()
               .HasKey(ba => new { ba.BookID, ba.CustomerID });

            // FK to Books
            modelBuilder.Entity<Reviews>()
                .HasOne(ba => ba.Books)
                .WithMany(b => b.Reviews)
                .HasForeignKey(ba => ba.BookID);

            // FK to Customers
            modelBuilder.Entity<Reviews>()
                .HasOne(ba => ba.Customers)
                .WithMany(a => a.Reviews)
                .HasForeignKey(ba => ba.CustomerID);


            modelBuilder.Entity<OrderItems>()
              .HasKey(ba => new { ba.BookID, ba.OrderID});

            // FK to Books
            modelBuilder.Entity<OrderItems>()
                .HasOne(ba => ba.Books)
                .WithMany(b => b.OrderItems)
                .HasForeignKey(ba => ba.BookID);

            // FK to Customers
            modelBuilder.Entity<OrderItems>()
                .HasOne(ba => ba.Orders)
                .WithMany(a => a.OrderItems)
                .HasForeignKey(ba => ba.OrderID);

            modelBuilder.Entity<Employees>()
                .HasOne(e => e.Manager)
                .WithMany()
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.Restrict); 
        }

    }
}
