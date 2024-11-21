using Ecommerce.Core.Entities;
using Ecommerce.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

namespace Ecommerce.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository) => _productRepository = productRepository;

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        var products = await _productRepository.GetProductAsync();
        
        return Ok(products);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProducts(int id)
    {
        var product = await _productRepository.GetProductAsync(id);

        return product;
    }
}
