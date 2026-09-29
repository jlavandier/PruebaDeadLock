using Microsoft.EntityFrameworkCore;

namespace Prueba.Context
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }
        
        public DbSet<Prueba.Models.Clientes> Clientes { get; set; }
        public DbSet<Prueba.Models.Ordenes> Ordenes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Prueba.Models.Clientes>(e =>
            {
                e.ToTable("Clientes");
                e.HasKey(c => c.Id);
                e.Property(c => c.Nombre).IsRequired().HasMaxLength(100);
                e.Property(c => c.Apellido).IsRequired().HasMaxLength(100);
            });
                

            modelBuilder.Entity<Prueba.Models.Ordenes>(e =>
            {
               e.ToTable("Ordenes");
                e.HasKey(o => o.Id);
                e.Property(o => o.Producto).IsRequired().HasMaxLength(100);
                e.Property(o => o.Cantidad).IsRequired();
                e.HasOne<Prueba.Models.Clientes>()
                    .WithMany()
                    .HasForeignKey(o => o.ClienteId);                   
            });

        }
    }
}
