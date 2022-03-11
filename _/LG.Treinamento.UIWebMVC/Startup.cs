using FluentValidation.AspNetCore;
using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Servicos;
using LG.Treinamento.Negocio.Interfaces;
using LG.Treinamento.Negocio.Objetos;
using LG.Treinamento.ServicoMapeador.Mapeadores.Mapeamentos;
using LG.Treinamento.ServicoMapeador.Mapeadores.Repositorios;
using LG.Treinamento.ServicoMapeador.Servicos.ContratosImplementados;
using LG.Treinamento.ServicoMapeador.Servicos.Conversores;
using LG.Treinamento.ServicoMapeador.Validacoes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace LG.Treinamento.UIWebMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddTransient(x => new NHibernateClass(Configuration.GetConnectionString("NHibernate")).Session);
            services.AddTransient<IRepositorioGenerico<Estagiario>, RepositorioGenerico<Estagiario>>();
            services.AddTransient<IRepositorioGenerico<Turma>, RepositorioGenerico<Turma>>();
            services.AddSingleton<ConversorEstagiario>();
            services.AddSingleton<ConversorTurma>();
            services.AddScoped<IServiceEstagiario, ServiceEstagiario>();
            services.AddScoped<IServiceTurma, ServiceTurma>();
            services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(Assembly.Load("LG.Treinamento.ServicoMapeador")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
