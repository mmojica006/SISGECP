using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.EntityMapper
{
    public class CargoMap : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {

            builder.HasKey(e => e.id)
                    .HasName("PK_tbl_cargo_IdCargo");

            builder.ToTable("cargo");

            builder.HasComment("Tabla que almacena los cargos de los docentes");

            builder.Property(e => e.id).HasColumnName("idCargo");

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
