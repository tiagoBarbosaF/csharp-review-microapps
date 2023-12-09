using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static Main;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureAppConfiguration((host, config) =>
{
    var fullName = Directory.GetParent(AppContext.BaseDirectory)?.FullName;
    if (fullName != null)
        config.SetBasePath(fullName);
    config.AddJsonFile(@"C:\dev\csharp\MicroApps\DataAccess\appsettings.json", optional: false, reloadOnChange: true);
});

builder.ConfigureServices((host, services) =>
{
    var connectionString = host.Configuration.GetConnectionString("DefaultConnection");
    services.AddDbContext<DataContextSqlite>(options =>
        options.UseSqlite(connectionString));
});

var app = builder.Build();

Start();

app.Run();