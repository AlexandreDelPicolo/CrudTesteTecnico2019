using CrudTesteTecnico2019.Application.Usuario.Handler;
using CrudTesteTecnico2019.Database.Database;
using CrudTesteTecnico2019.Database.Database.Usuario;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrudTesteTecnico2019.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration _configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfigurarBanco(services);
            InjetarDependencias(services);
        }

        private void ConfigurarBanco(IServiceCollection services)
        {
            services.AddDbContextPool<Context>(options => options.UseSqlServer(obterConnectionString()));
            services.BuildServiceProvider().GetRequiredService<Context>().Database.Migrate();
        }

        private string obterConnectionString()
        {
            return _configuration["ConnectionString"];
        }

        private void InjetarDependencias(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddMediatR
            (
                typeof(Startup),
                typeof(UsuarioCommandHandler)
            );
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
