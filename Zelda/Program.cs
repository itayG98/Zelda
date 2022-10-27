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

//Possible correct registeration 1 : WRONG
//builder.Services.AddTransient<IDbContextFactory<ZeldaContext>, DbContextFactory<ZeldaContext>>();

//Possible correct registeration 2 : WRONG
//builder.Services.AddTransient<IDbContextDependencies, ZeldaContext>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ZeldaContext>();
    context.Database.EnsureCreated();
    context.Seed();
}

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Deafult", "{controller=Home}/{action=Index}/{id?}");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Sorry cant serve your request");
});

app.Run();
