using CrudTesteTecnico2019.Domain.Usuario.Entity;
using CrudTesteTecnico2019.Domain.Usuario.Enum;
using Microsoft.EntityFrameworkCore;
using System;

namespace CrudTesteTecnico2019.Database.Database
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedUsers();
        }

        private static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioEntity>(x =>
            {
                x.HasData(new
                {
                    UsuarioId = 1L,
                    Nome = "Alexandre",
                    Sobrenome = "Del Picolo",
                    Perfil = Perfil.Usuario
                });

                x.OwnsOne(y => y.Email).HasData(new
                {
                    UsuarioEntityUsuarioId = 1L,
                    Value = "administrator@administrator.com"
                });

                x.OwnsOne(y => y.DataNascimento).HasData(new
                {
                    UsuarioEntityUsuarioId = 1L,
                    Value = DateTime.Now
                });


                // Usuário dois
                x.HasData(new
                {
                    UsuarioId = 2L,
                    Nome = "Rafael",
                    Sobrenome = "Garcia",
                    Perfil = Perfil.Administrador
                });

                x.OwnsOne(y => y.Email).HasData(new
                {
                    UsuarioEntityUsuarioId = 2L,
                    Value = "rafaelfgx@gmail.com"
                });

                x.OwnsOne(y => y.DataNascimento).HasData(new
                {
                    UsuarioEntityUsuarioId = 2L,
                    Value = DateTime.Now.AddYears(-29)
                });

                // Usuário três
                x.HasData(new
                {
                    UsuarioId = 3L,
                    Nome = "Luciano",
                    Sobrenome = "Lima",
                    Perfil = Perfil.Supervisor
                });

                x.OwnsOne(y => y.Email).HasData(new
                {
                    UsuarioEntityUsuarioId = 3L,
                    Value = "lucishow@gmail.com"
                });

                x.OwnsOne(y => y.DataNascimento).HasData(new
                {
                    UsuarioEntityUsuarioId = 3L,
                    Value = DateTime.Now.AddYears(-27)
                });

                // Usuário quatro
                x.HasData(new
                {
                    UsuarioId = 4L,
                    Nome = "Bruno",
                    Sobrenome = "Lima",
                    Perfil = Perfil.Supervisor
                });

                x.OwnsOne(y => y.Email).HasData(new
                {
                    UsuarioEntityUsuarioId = 4L,
                    Value = "bruno.lima@gmail.com"
                });

                x.OwnsOne(y => y.DataNascimento).HasData(new
                {
                    UsuarioEntityUsuarioId = 4L,
                    Value = DateTime.Now.AddYears(-27)
                });
            });
        }
    }
}
