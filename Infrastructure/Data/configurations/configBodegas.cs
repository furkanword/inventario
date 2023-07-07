using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class configBodegas : IEntityTypeConfiguration<Bodega>
{

    public void Configure(EntityTypeBuilder<Bodega> builder)
    {
        builder.ToTable("Bodegas");

        builder.Property(b => b.Id)
        .HasColumnName("Id")
        .HasColumnType("bigint(20)")
        .IsRequired();

        builder.Property(b => b.Nombre)
        .HasColumnName("Nombre")
        .HasColumnType("varchar(255)")
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(b => b.Id_responsable)
        .HasColumnType("bigint(20)")
        .HasColumnName("Id_responsable");

        builder.Property(b => b.Estado)
        .HasColumnName("Estado")
        .HasColumnType("tinyint(4)");

        builder.Property(b => b.Created_by)
        .HasColumnName("Created_by")
        .HasColumnType("bigint(20)");

        builder.Property(b => b.Update_by)
        .HasColumnName("update_by")
        .HasColumnType("bigint(20)");

        builder.Property(b => b.Created_at)
        .HasColumnName("Created_at")
        .HasColumnType("timestamp");

        builder.Property(b => b.Updated_at)
        .HasColumnName("update_at")
        .HasColumnType("timestamp");

        builder.Property(b => b.Deleted_at)
        .HasColumnName("Deleted_at")
        .HasColumnType("timestamp");

        builder.HasOne(b => b.CreatorUser)
        .WithMany(b => b.Bodegas)
        .HasForeignKey(p => p.Created_by);

        builder.HasOne(b => b.UpdatedUser)
        .WithMany(b => b.BodegasUpdated)
        .HasForeignKey(p => p.Update_by);

        builder.HasOne(b => b.ResponsableUser)
        .WithMany(b => b.BodegasResponsable)
        .HasForeignKey(p => p.Id_responsable);


        


       


    }
}
