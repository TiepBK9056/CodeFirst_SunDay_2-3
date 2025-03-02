using CodeFirst.Models;

namespace CodeFirst.Repository;

public class MockProductRepository : IProductRepository {

    private readonly ProductContextDb _context;

    public MockProductRepository(ProductContextDb context){
        _context = context;
    }

    public  async Task<Product> AddProductAsync(Product product){
        var newProduct = await _context.Products.AddAsync(product); 
        return newProduct.Entity;
    }

    public  async Task<Product> GetProductByIdAsync(int id) {
        return await _context.Products.FindAsync(id);
    }

    public  IEnumerable<Product> GetAllProductAsync() {
        return _context.Products.ToList();
    }

    public  async Task<Product> UpdateProductAsync(Product product){
        var updateProduct = _context.Products.Update(product);
        return updateProduct.Entity;
    }

    public  async Task DeleteProductAsync(int id){
        var product = await _context.Products.FindAsync(id);
        if(product != null){
            _context.Products.Remove(product);
        }
    }
}