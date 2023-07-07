using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations;

public class ConfigHistoriales: IEntityTypeConfiguration<Historial>
{
    public void Configure(EntityTypeBuilder<Historial> builder)
    {
        builder.ToTable("Historial");

        builder.Property(x => x.Id)
        .HasColumnName("Id")
        .HasColumnType("bigint(20)")
        .IsRequired();

        builder.Property(x => x.Cantidad)
        .HasColumnName("Cantidad")
        .HasColumnType("int(20)");

        builder.Property(x => x.Id_bodega_destino)
        .HasColumnName("id_bodega_destino")
        .HasColumnType("bigint(20)")
        .IsRequired();

        builder.Property(x => x.Id_bodega_origen)
        .HasColumnName("id_bodega_origen") 
        .HasColumnType("bigint(20)")
        .IsRequired(); 

        builder.Property(x => x.Id_inventario)
        .HasColumnName("id_inventario")
        .HasColumnType("bigint(20)")
        .IsRequired();

        builder.Property(x => x.Created_by)
        .HasColumnName("created_by")
        .HasColumnType("bigint(20)")
        .IsRequired();

        builder.Property(x => x.Updated_by)
        .HasColumnName("updated_by")
        .HasColumnType("bigint(20)")
        .IsRequired();

        builder.Property(x => x.Created_at)
        .HasColumnName("created_at")
        .HasColumnType("timestamp");

        builder.Property(x => x.Updated_at)
        .HasColumnName("updated_at")
        .HasColumnType("timestamp");

        builder.Property(x => x.Deleted_at)
        .HasColumnName("deleted_at")
        .HasColumnType("timestamp");

        builder.HasOne(x => x.CreatorUser)
        .WithMany(x => x.Historiales)
        .HasForeignKey(x => x.Created_by);

        builder.HasOne(x => x.UpdaterUser)
        .WithMany(x => x.HistorialesUpdated)
        .HasForeignKey(x => x.Updated_by);

        builder.HasOne(x => x.BodegaOrigen)
        .WithMany(x => x.Historiales)
        .HasForeignKey(x => x.Id_bodega_origen);

        builder.HasOne(x => x.BodegaDestino)
        .WithMany(x => x.HistorialesDestino)
        .HasForeignKey(x => x.Id_bodega_destino);

        builder.HasOne(x => x.Inventario)
        .WithMany(x => x.Historiales)
        .HasForeignKey(x => x.Id_inventario);
        
    }
    
}
