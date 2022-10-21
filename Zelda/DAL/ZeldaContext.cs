using Microsoft.EntityFrameworkCore;
using Zelda.Models;

internal class ZeldaContext :  DbContext
{

    public ZeldaContext(DbContextOptions<ZeldaContext> options) : base(options)
    {

    }

    public DbSet<IceCream> IceCreams { get; set; }
    public DbSet<Syrop> Syrops { get; set; }
    public DbSet<Order> Orders { get; set; }
}
