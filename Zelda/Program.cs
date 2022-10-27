using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Zelda.Models;
using Zelda.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddTransient<IRepositoryBase<IceCream, int, ZeldaContext>, IceCreamRepository>();
builder.Services.AddTransient<IRepositoryBase<Syrop, int, ZeldaContext>, SyropRepository>();
builder.Services.AddTransient<IRepositoryBase<Address, int, ZeldaContext>, AddressRepository>();
builder.Services.AddTransient<IRepositoryBase<Costumer, string, ZeldaContext>, CustomerRepository>();
builder.Services.AddTransient<IRepositoryBase<Order, Guid, ZeldaContext>, OrdersRepository>();

builder.Services.AddDbContext<ZeldaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
}
);
builder.Services.AddControllersWithViews();

//Possible correct registeration 1 : WRONG
//builder.Services.AddTransient<IDbContextFactory<ZeldaContext>, DbContextFactory<ZeldaContext>>();

//Possible correct registeration 2 : WRONG
//builder.Services.AddTransient<IDbContextDependencies, ZeldaContext>();



var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ZeldaContext>();
    context.Database.EnsureCreated();
}


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
