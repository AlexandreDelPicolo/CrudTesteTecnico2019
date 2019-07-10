﻿using CrudTesteTecnico2019.Domain.Usuario.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudTesteTecnico2019.Database.Database.Usuario
{
    public sealed class UserDomainConfiguration : IEntityTypeConfiguration<UsuarioDomain>
    {
        public void Configure(EntityTypeBuilder<UsuarioDomain> builder)
        {
            builder.ToTable("Usuario_tb", "CrudTesteTecnico");
            builder.HasKey(x => x.UsuarioId);
            builder.Property(x => x.UsuarioId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Sobrenome).IsRequired().HasMaxLength(100);

            builder.OwnsOne(x => x.Email, y =>
            {
                y.Property(x => x.Value).HasColumnName(nameof(UsuarioDomain.Email)).IsRequired().HasMaxLength(300);
            });

            builder.OwnsOne(x => x.DataNascimento, y =>
            {
                y.Property(x => x.Value).HasColumnName(nameof(UsuarioDomain.DataNascimento)).IsRequired();
            });

            builder.Property(x => (int)x.Perfil).IsRequired();
        }
    }
}
