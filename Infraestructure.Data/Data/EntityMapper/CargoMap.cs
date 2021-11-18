using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.EntityMapper
{
    public class CargoMap : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {

            builder.ToTable("Cargo");

            builder.HasComment("Tabla que almacena los cargos de los docentes");

            builder.Property(e => e.id).HasColumnName("id");

            builder.Property(e => e.estado)
                .IsRequired()
                .HasColumnName("estado")
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.nombre)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        }
    }
}
