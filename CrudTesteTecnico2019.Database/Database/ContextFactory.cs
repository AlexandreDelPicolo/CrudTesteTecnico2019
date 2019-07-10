using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CrudTesteTecnico2019.Database.Database
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<Context> builder = new DbContextOptionsBuilder<Context>();

            builder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CrudTesteTecnico;Integrated Security=true;Connection Timeout=5;");

            return new Context(builder.Options);
        }
    }
}
