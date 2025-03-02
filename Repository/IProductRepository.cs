using CodeFirst.Models;

namespace CodeFirst.Repository;

public interface IProductRepository 
{
    public  Task<Product> AddProductAsync(Product product);

    public  Task<Product> GetProductByIdAsync(int id);

    public  IEnumerable<Product> GetAllProductAsync();

    public  Task<Product> UpdateProductAsync(Product product);

    public  Task DeleteProductAsync(int id);
}

