using Microsoft.EntityFrameworkCore;
using Zelda.Models;

public class ZeldaContext :  DbContext
{

    public ZeldaContext(DbContextOptions<ZeldaContext> options) : base(options)
    {

    }

    public DbSet<IceCream> IceCreams { get; set; }
    public DbSet<Syrop> Syrops { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Costumer> Costumers { get; set; }
    public DbSet<Address> Addreses { get; set; }


}
