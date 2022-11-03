using Microsoft.EntityFrameworkCore;
using Zelda.Models;

public class ZeldaContext : DbContext
{

    public ZeldaContext(DbContextOptions<ZeldaContext> options) : base(options)
    {

    }

    public DbSet<IceCream> IceCreams { get; set; }
    public DbSet<Syrop> Syrops { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Costumer> Costumers { get; set; }
    public DbSet<Address> Addreses { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IceCream>().HasData(
         new IceCream() { IceCreamID = 1, Name = "Chocolate Milk", Price = 6.5, ImgSrc = "Default" },
         new IceCream() { IceCreamID = 2, Name = "Yummy Vannila", Price = 6, ImgSrc = "Default" },
         new IceCream() { IceCreamID = 3, Name = "Strawberry", Price = 5, ImgSrc = "Default" },
         new IceCream() { IceCreamID = 4, Name = "Juicy Lemon", Price = 5, ImgSrc = "Default" });

        modelBuilder.Entity<Syrop>().HasData(
        new Syrop() { SyropID = 1, Name = "Strawberry", ImgSrc = "Default" },
         new Syrop() { SyropID = 2, Name = "Dark Chocolate", ImgSrc = "Default" });

        modelBuilder.Entity<Topping>().HasData(
         new Topping() { ToppingID = 1, Name = "Pecans", ImgSrc = "Default" },
         new Topping() { ToppingID = 2, Name = "Candies", ImgSrc = "Default" });
    }
}
