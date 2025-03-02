using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models;

public class Category {
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }

    // Navigation property - dùng được inclue nhanh chóng
    public List<Product>? Products { get; set; } = new (); 
}