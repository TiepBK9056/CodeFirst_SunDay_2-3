using CodeFirst.Models;
using CodeFirst.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers;

public class ProductController : Controller {
    private readonly IProductRepository _productRepository;
    public ProductController(IProductRepository productRepository){
        _productRepository = productRepository;
    }

    [HttpPost]
    public async Task<IActionResult> AddProduct(Product product){
        var newProduct = await _productRepository.AddProductAsync(product);
        return View(newProduct);
    }


    
}