using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GravityBookstore.DB;

public class AppDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Book_language> BookLanguages { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Book_author> BookAuthors { get; set; }
    public DbSet<Address_status> AddressStatuses { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Customer_address> CustomerAddresses { get; set; }
    public DbSet<Shipping_method> ShippingMethods { get; set; }
    public DbSet<Cust_order> Orders { get; set; }
    public DbSet<Order_status> OrderStatuses { get; set; }
    public DbSet<Order_line> OrderLines { get; set; }
    public DbSet<Order_history> OrderHistories { get; set; }


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }


    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //  optionsBuilder.UseNpgsql("Host = localhost; Database = Bookstore; username = postgres; Password = 1234");
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Book_author>(entity =>
        {
            entity.HasKey(e => new { e.Author_id, e.Book_id });

            entity.HasOne(e => e.Author)
                .WithMany(e => e.BookAuthors)
                .HasForeignKey(e => e.Author_id);

            entity.HasOne(e => e.Book)
                .WithMany(e => e.BookAuthors)
                .HasForeignKey(e => e.Book_id);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Book_id);

            entity.HasOne(e => e.Language)
                .WithMany(e => e.Books)
                .HasForeignKey(e => e.Book_language_id);

            entity.HasOne(e => e.Publisher)
                .WithMany(e => e.Books)
                .HasForeignKey(e => e.Publisher_id);
        });

        modelBuilder.Entity<Order_line>(entity =>
        {
            entity.HasKey(e => e.Line_id);

            entity.HasOne(e => e.Cust_order)
                .WithMany(e => e.Order_lines)
                .HasForeignKey(e => e.Line_id);

            entity.HasOne(e => e.Book)
                .WithMany(e => e.Order_lines)
                .HasForeignKey(e => e.Book_id);
        });

        modelBuilder.Entity<Cust_order>(entity =>
        {
            entity.HasKey(e => e.Order_id);

            entity.HasOne(e => e.Customer)
                .WithMany(e => e.Cust_order)
                .HasForeignKey(e => e.Customer_id);

            entity.HasOne(e => e.Shipping_method)
                .WithMany(e => e.Cust_order)
                .HasForeignKey(e => e.Shipping_id);

            entity.HasOne(e => e.Dest_address)
                .WithMany(e => e.Cust_order)
                .HasForeignKey(e => e.Dest_address_id);
        });

        modelBuilder.Entity<Customer_address>(entity =>
        {
            entity.HasKey(e => new { e.Customer_id, e.Address_id });

            entity.HasOne(e => e.Customer)
                .WithMany(e => e.Customer_address)
                .HasForeignKey(e => e.Customer_id);

            entity.HasOne(e => e.Address)
                .WithMany(e => e.Customer_address)
                .HasForeignKey(e => e.Address_id);

            entity.HasOne(e => e.Address_status)
                .WithMany(e => e.Customer_address)
                .HasForeignKey(e => e.Status_id);
        });

        modelBuilder.Entity<Order_history>(entity =>
        {
            entity.HasKey(e => e.History_id);

            entity.HasOne(e => e.Cust_order)
                .WithMany(e => e.Order_history)
                .HasForeignKey(e => e.Cust_order_id);

            entity.HasOne(e => e.Status)
                .WithMany(e => e.History)
                .HasForeignKey(e => e.Status_id);
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Address_id);

            entity.HasOne(e => e.Country)
                .WithMany(e => e.Addresses)
                .HasForeignKey(e => e.Country_id);
        });
        
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Customer_id);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Country_id);
        });

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Author_id);
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.Publisher_id);
        });

        modelBuilder.Entity<Book_language>(entity =>
        {
            entity.HasKey(e => e.Language_id);
        });

        modelBuilder.Entity<Address_status>(entity =>
        {
            entity.HasKey(e => e.Status_id);
        });

        modelBuilder.Entity<Shipping_method>(entity =>
        {
            entity.HasKey(e => e.Method_id);
        });

        modelBuilder.Entity<Order_status>(entity =>
        {
            entity.HasKey(e => e.Status_id);
        });


        
    }
}
