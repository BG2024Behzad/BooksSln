using Microsoft.EntityFrameworkCore;
using BooksStore.Models;
using System.Collections.Generic;
namespace BookStore.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
        : base(options) { }
        public DbSet<Product> Products => Set<Product>();

    }
}