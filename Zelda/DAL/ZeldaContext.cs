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
    public DbSet<Address> Addresses { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IceCream>().HasData(
         new IceCream() { IceCreamID = 1, Name = "Chocolate Milk", Price = 6.5, ImgSrc = "Chocolate_Milk_img.png" },
         new IceCream() { IceCreamID = 2, Name = "Yummy Vannila", Price = 6, ImgSrc = "Yummy_vanilla.png" },
         new IceCream() { IceCreamID = 3, Name = "Strawberry", Price = 5, ImgSrc = "StrawBerry_imge.png" },
         new IceCream() { IceCreamID = 4, Name = "Juicy Lemon", Price = 5, ImgSrc = "JuicyLemno_Image.png" });

        modelBuilder.Entity<Syrop>().HasData(
        new Syrop() { SyropID = 1, Name = "Strawberry", ImgSrc = "Strawberry_Syrop.png" },
         new Syrop() { SyropID = 2, Name = "Dark Chocolate", ImgSrc = "Chocolate_Syrop.png" });

        modelBuilder.Entity<Topping>().HasData(
         new Topping() { ToppingID = 1, Name = "Pecans", ImgSrc = "Pecans_Top.png" },
         new Topping() { ToppingID = 2, Name = "Candies", ImgSrc = "Candis_Top.png" });
    }
}
