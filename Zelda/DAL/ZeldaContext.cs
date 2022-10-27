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

    internal void Seed()
    {
        List<IceCream> iceCreams = new List<IceCream>() {
         new IceCream() {Name="Chocolate Milk" , Price=6.5 ,ImgSrc="Default"},
         new IceCream() {Name= "Yummy Vannila", Price=6 ,ImgSrc="Default"},
         new IceCream() {Name= "Strawberry", Price=5, ImgSrc = "Default"},
         new IceCream() {Name= "Juicy Lemon", Price=5, ImgSrc = "Default"}
         };

        List<Syrop> syrops = new List<Syrop>() {
         new Syrop(){Name="Strawberry" ,ImgSrc="Default" },
         new Syrop(){Name="Dark Chocolate",ImgSrc="Default" }
        };

        List<Topping> topping = new List<Topping>() {
         new Topping() {Name="Pecans",ImgSrc="Default" },
         new Topping() {Name="Candies",ImgSrc="Default"}
        };

        IceCreams.AddRange(iceCreams);
        Syrops.AddRange(syrops);
        Toppings.AddRange(topping);
        SaveChanges();
    }
}
