using ApisWithEf.Models;
using Microsoft.EntityFrameworkCore;

namespace ApisWithEf.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Category>? Categories { get; init; }
    public DbSet<Product>? Products { get; init; }
}