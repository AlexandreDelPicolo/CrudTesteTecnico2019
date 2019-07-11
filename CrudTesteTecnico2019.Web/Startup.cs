using CrudTesteTecnico2019.Application.Usuario.Handler;
using CrudTesteTecnico2019.Database.Database;
using CrudTesteTecnico2019.Database.Database.Usuario;
using CrudTesteTecnico2019.Domain.Usuario.Command;
using CrudTesteTecnico2019.Domain.Usuario.Validation;
using CrudTesteTecnico2019.Infrastructure.ManagerResult;
using CrudTesteTecnico2019.Infrastructure.Result;
using FluentValidation;
using FluentValidation.AspNetCore;
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
            InjetarValidacoes(services);
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
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IManagerResult, ManagerResult>();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation();

            services.AddMediatR
            (
                typeof(Startup),
                typeof(UsuarioCommandHandler)
            );
        }

        private void InjetarValidacoes(IServiceCollection services)
        {
            services.AddTransient<IValidator<UsuarioBaseCommand>, UsuarioBaseCommandValidator>();
            services.AddTransient<IValidator<UsuarioInsertCommand>, UsuarioInsertCommandValidator>();
            services.AddTransient<IValidator<UsuarioEditCommand>, UsuarioEditCommandValidator>();
            services.AddTransient<IValidator<UsuarioDeleteCommand>, UsuarioDeleteCommandValidator>();
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
