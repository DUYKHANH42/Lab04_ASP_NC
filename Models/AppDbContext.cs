using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab04.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
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
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" }
                );
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Admin@123"),
                    Email = "admin123@gmail.com",
                    NormalizedEmail = "ADMIN123@GMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "STATIC_SECURITY_STAMP_1",
                });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string> { UserId = "1", RoleId = "1" }
                 );
        }

    }
}
