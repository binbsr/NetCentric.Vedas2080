using BookStore.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
public class BookStoreDb: IdentityDbContext
{
    public DbSet<Author> Authors { get; set; }

    public BookStoreDb(DbContextOptions<BookStoreDb> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=BookStore.db");
    }
}