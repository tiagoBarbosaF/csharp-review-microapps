using ApisWithEf.Data;
using ApisWithEf.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApisWithEf.Controllers;

[ApiController]
[Route("v1/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Product>>> Get([FromServices] DataContext context)
    {
        if (context.Products == null) return NotFound(ModelState);
        return await context.Products
            .Include(product => product.Category)
            .AsNoTracking()
            .ToListAsync();
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Product>> GetById([FromServices] DataContext context, int id)
    {
        if (context.Products == null) return NotFound(ModelState);
        var product = await context.Products
            .Include(product => product.Category)
            .AsNoTracking()
            .FirstOrDefaultAsync(product => product.Id == id);
        if (product == null) return NotFound(ModelState);

        return product;
    }

    [HttpGet]
    [Route("categories/{id:int}")]
    public async Task<ActionResult<List<Product>>> GetByCategoryId([FromServices] DataContext context, int id)
    {
        if (context.Products != null)
            return await context.Products
                .Include(product => product.Category)
                .AsNoTracking()
                .Where(product => product.CategoryId == id)
                .ToListAsync();
        return NotFound(ModelState);
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<Product>> Post([FromServices] DataContext context, Product product)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        context.Products?.Add(product);
        await context.SaveChangesAsync();
        return product;
    }
}