using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.configuration;
public class ConfigProductos : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("Productos");

        builder.Property(P => P.Id)
        .HasColumnType("bigint(20)")
        .HasColumnName("id")
        .IsRequired();

        builder.Property(P => P.Nombre)
        .HasColumnType("varchar(255)")
        .HasColumnName("nombre")
        .IsRequired()
        .HasMaxLength(50);

       builder.Property(P => P.Descripcion)
            .HasColumnType("varchar(255)")
            .HasColumnName("descripcion")
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(P => P.Estado)
               .HasColumnType("tinyint(4)");
        
        builder.Property(P => P.Created_by)
        .HasColumnType("bigint(20)")
        .HasColumnName("created_by")
        .IsRequired();

        builder.Property(P => P.Updated_by)
        .HasColumnType("bigint(20)")
        .HasColumnName("updated_by")
        .IsRequired();

        builder.Property(P => P.Deleted_at)
        .HasColumnType("timestamp")
        .HasColumnName("deleted_at");

        builder.HasOne(P => P.CreatorUser)
        .WithMany(p => p. Productos)
        .HasForeignKey(p => p.Created_by);

        builder.HasOne(P => P.UpdaterUser)
       .WithMany(p => p. ProductosUpdated)
       .HasForeignKey(p => p.Updated_by);
    }
}
