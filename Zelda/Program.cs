using Microsoft.EntityFrameworkCore;
using Zelda.Models;
using Zelda.Repositories;

var builder = WebApplication.CreateBuilder(args);
var conn = builder.Configuration.GetConnectionString("DefaultConnectionString");
// Add services to the container.
builder.Services.AddDbContext<ZeldaContext>(options =>
{
    options.UseSqlServer(conn);
}
);


/*
 * builder.Services.AddDbContextFactory<ZeldaContext>(opt =>
    opt.UseSqlServer($"Data Source={nameof(ZeldaContext.Database)}.db")
    .EnableSensitiveDataLogging());
*/

builder.Services.AddScoped<IRepositoryBase<IceCream, int, ZeldaContext>, IceCreamRepository>();
builder.Services.AddScoped<IRepositoryBase<Syrop, int, ZeldaContext>, SyropRepository>();
builder.Services.AddScoped<IRepositoryBase<Address, int, ZeldaContext>, AddressRepository>();
builder.Services.AddScoped<IRepositoryBase<Costumer, string, ZeldaContext>, CustomerRepository>();
builder.Services.AddScoped<IRepositoryBase<Order, Guid, ZeldaContext>, OrdersRepository>();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Sorry cant serve your request");
});

app.Run();
