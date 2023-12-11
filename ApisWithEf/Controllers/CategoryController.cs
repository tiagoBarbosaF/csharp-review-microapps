using ApisWithEf.Data;
using ApisWithEf.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApisWithEf.Controllers;

[ApiController]
[Route("v1/categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context)
    {
        if (context.Categories == null) return NotFound(ModelState);

        var categories = await context.Categories.ToListAsync();
        return categories;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<Category>> Post([FromServices] DataContext context, [FromBody] Category category)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        context.Categories?.Add(category);
        await context.SaveChangesAsync();
        return category;
    }
}