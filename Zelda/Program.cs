using Microsoft.EntityFrameworkCore;
using Zelda.Models;
using Zelda.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddTransient<IceCreamRepository>();
builder.Services.AddTransient<SyropRepository>();
builder.Services.AddTransient<ToppingRepository>();
builder.Services.AddTransient<AddressRepository>();
builder.Services.AddTransient<CustomerRepository>();
builder.Services.AddTransient< OrdersRepository>();

builder.Services.AddDbContext<ZeldaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
}
);
builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ZeldaContext>();
    context.Database.EnsureCreated();
}

app.UseRouting();
app.UseStaticFiles();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Deafult", "{controller=IceCream}/{action=Index}/{id?}");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Sorry cant serve your request");
});

app.Run();
