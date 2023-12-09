using DatabaseReview.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data;

public class DataContextSqlite : DbContext
{
    public DataContextSqlite(DbContextOptions<DataContextSqlite> options) : base(options)
    {
    }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("Data Source=DefaultDB.db");
    // }

    public DbSet<Product> Products { get; set; }
}