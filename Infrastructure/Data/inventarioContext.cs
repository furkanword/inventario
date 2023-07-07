using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data
{
    public class InventarioContext : DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext> options): base(options){}

        public DbSet<Producto> productos { get; set; }
        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Historial> Historiales { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }



        
    }
}