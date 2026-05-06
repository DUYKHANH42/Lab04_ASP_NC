using Microsoft.EntityFrameworkCore;

namespace Lab04.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Điện thoại" },
                    new Category { Id = 2, Name = "Laptop" },
                    new Category { Id = 3, Name = "Tablet" }
                );
                modelBuilder.Entity<Product>().HasData(
                    new Product { Id = 1, Name = "iPhone 13", Price = 999.99m, CategoryId = 1 },
                    new Product { Id = 2, Name = "Samsung Galaxy S21", Price = 899.99m, CategoryId = 1 },
                    new Product { Id = 3, Name = "MacBook Pro", Price = 1999.99m, CategoryId = 2 },
                    new Product { Id = 4, Name = "Dell XPS 13", Price = 1499.99m, CategoryId = 2 },
                    new Product { Id = 5, Name = "iPad Pro", Price = 799.99m, CategoryId = 3 }
                );
        }

    }
}
