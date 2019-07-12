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

        public void ConfigureServices(IServiceCollection services)
        {
            AdicionarBancoDados(services);
            AdicionarDependencias(services);
            AdicionarValidators(services);
        }

        private void AdicionarBancoDados(IServiceCollection services)
        {
            services.AddDbContextPool<Context>(options => options.UseSqlServer(_configuration["ConnectionString"]));
            services.BuildServiceProvider().GetRequiredService<Context>().Database.Migrate();
        }

        private void AdicionarDependencias(IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IManagerResult, ManagerResult>();

            services.AddMvc().AddFluentValidation();

            services.AddMediatR(typeof(Startup), typeof(UsuarioCommandHandler));
        }

        private void AdicionarValidators(IServiceCollection services)
        {
            services.AddTransient<IValidator<UsuarioBaseCommand>, UsuarioBaseCommandValidator>();
            services.AddTransient<IValidator<InserirUsuarioCommand>, InserirUsuarioCommandValidator>();
            services.AddTransient<IValidator<AtualizarUsuarioCommand>, AtualizarUsuarioCommandValidator>();
            services.AddTransient<IValidator<ExcluirUsuarioCommand>, ExcluirUsuarioCommandValidator>();
        }
    }
}