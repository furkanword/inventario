using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.configurations;

public class ConfigInventarios :IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder){

        builder.ToTable("Inventarios");

        builder.Property(i => i.Id)
        .HasColumnType("bigint(20)")
        .HasColumnName("id")
        .IsRequired();

        builder.Property(i => i.Id_bodega)
        .HasColumnType("bigint(20)")
        .HasColumnName("id_bodega")
        .IsRequired();

        builder.Property(i => i.Id_producto)
        .HasColumnType("bigint(20)")
        .HasColumnName("id_producto")
        .IsRequired();

        builder.Property(i => i.Cantidad)
        .HasColumnType("int(20)")
        .HasColumnName("cantidad");

        builder.Property(i => i.Created_by)
        .HasColumnType("bigint(20)")
        .HasColumnName("created_by")
        .IsRequired();

        builder.Property(i => i.Updated_by)
        .HasColumnType("bigint(20)")
        .HasColumnName("updated_by")
        .IsRequired();

        builder.Property(i => i.Created_at)
        .HasColumnType("timestamp")
        .HasColumnName("created_at");
      

        builder.Property(i => i.Updated_at)
        .HasColumnType("timestamp")
        .HasColumnName("updated_at");

        builder.Property(i => i.Deleted_at)
        .HasColumnType("timestamp")
        .HasColumnName("deleted_at");

        builder.HasOne(i => i.CreatorUser)
        .WithMany(i => i.Inventarios)
        .HasForeignKey(i => i.Created_by);

        builder.HasOne(i => i.UpdatedUser)
        .WithMany(i => i.InventariosUpdated)
        .HasForeignKey(p => p.Updated_by);

        builder.HasOne(i => i.Producto)
        .WithMany(i => i.Inventarios)
        .HasForeignKey(p => p.Id_producto);

        builder.HasOne(i => i.Bodega)
        .WithMany(i => i.Inventarios)
        .HasForeignKey(i => i.Id_bodega);



     




    

    
    }

    
}
