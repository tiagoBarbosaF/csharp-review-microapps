using DatabaseReview.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data;

public class DataContextSqlite : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=DefaultDB.db");
    }

    public DbSet<Product> Products { get; set; }
}