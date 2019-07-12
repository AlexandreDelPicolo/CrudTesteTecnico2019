using CrudTesteTecnico2019.Database.Database.Usuario;
using Microsoft.EntityFrameworkCore;

namespace CrudTesteTecnico2019.Database.Database
{
    public sealed class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.Seed();
        }
    }
}