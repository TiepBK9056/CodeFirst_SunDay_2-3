using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models;

public class ProductContextDb : DbContext {
    public ProductContextDb(DbContextOptions<ProductContextDb> options) : base(options) 
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
    }
}