using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.configurations;

public class UserConguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder){

        builder.ToTable("Users");

        builder.Property(x => x.Id)
        .HasColumnType("bigint(20)")
        .HasColumnName("id")
        .IsRequired();

        builder.Property(x => x.Nombre)
        .HasColumnType("varchar(255)")
        .HasColumnName("nombre")
        .IsRequired()
        .HasMaxLength(50); 

        builder.Property(x => x.Email)
            .HasColumnType("varchar(255)")
            .HasColumnName("email")
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Email_verified_at)
            .HasColumnName("email_validate_at");

        builder.Property(x => x.Estado)
           .HasColumnName("estado")
           .HasColumnType("tinyint(4)");

        builder.Property(x => x.Created_by)
          .HasColumnType("tinyint(4)")
          .HasColumnName("created_by")
          .IsRequired();
        
        builder.Property(x => x.Updated_by)
            .HasColumnType("bigint(20)")
            .HasColumnName("updated_by")
            .IsRequired();

        builder.Property(x => x.Foto)
            .HasColumnType("varchar(255)")
            .HasColumnName("foto")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Password)
           .HasColumnType("varchar(255)")
           .HasColumnName("password")
           .IsRequired()
           .HasMaxLength(60);
        
        builder.Property(x => x.Created_at)
          .HasColumnType("timestamp")
          .HasColumnName("created_at");
        
        builder.Property(x => x.Updated_at)
         .HasColumnType("timestamp")
         .HasColumnName("updated_at");

        builder.Property(x => x.Deleted_at)
        .HasColumnType("timestamp")
        .HasColumnName("deleted_at"); 



    } 
}
