using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Entregable11.Entities;

public class MiDbContext : DbContext
{
    public MiDbContext() : base("name=DataBaseCoder")
    {
        Database.SetInitializer(new DataInitializer());
    }

    public DbSet<User> Usuarios { get; set; }
    public DbSet<Product> Productos { get; set; }
    public DbSet<ProductSold> ProductosVendidos { get; set; }
    public DbSet<Sales> Ventas { get; set; }
   

}

