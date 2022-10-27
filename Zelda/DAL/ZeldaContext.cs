using Microsoft.EntityFrameworkCore;
using Zelda.Models;

public class ZeldaContext : DbContext
{

    public ZeldaContext(DbContextOptions<ZeldaContext> options) : base(options)
    {

    }

    public DbSet<IceCream> IceCreams { get; set; }
    public DbSet<Syrop> Syrops { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Costumer> Costumers { get; set; }
    public DbSet<Address> Addreses { get; set; }

    internal void Seed()
    {
        List<IceCream> iceCreams = new List<IceCream>() {
         new IceCream() {Name="Chocolate Milk" , Price=6.5},
        new IceCream() {Name= "Yummy Vannila", Price=6},
        new IceCream() {Name= "Strawberry", Price=5},
            new IceCream() {Name= "Juicy Lemon", Price=5}
         };

        IceCreams.AddRange(iceCreams);
        SaveChangesAsync();
    }
}
