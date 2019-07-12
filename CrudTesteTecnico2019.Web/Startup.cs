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
using Swashbuckle.AspNetCore.Swagger;

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
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Crud teste técnico 2019");
            });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            AdicionarBancoDados(services);
            AdicionarDependencias(services);
            AdicionarValidators(services);
            AdicionarSwagger(services);
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

        private void AdicionarSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Crud test técnico 2019",
                        Version = "v1",
                        Description = "Teste técnico para avaliar meu conhecimento em .net core e angular.",
                        Contact = new Contact
                        {
                            Name = "Alexandre Del Picolo",
                            Url = "https://github.com/AlexandreDelPicolo"
                        }
                    });
            });
        }
    }
}