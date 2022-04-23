using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GeekTime.Manager;

namespace GeekTime
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            // This method is used to add services to the container.
            services.AddControllersWithViews();
            services.AddMvc(option => option.EnableEndpointRouting = false);// поддержка MVC
            services.AddTransient<IAdminManager, AdminManager>();
        } //для регистрации плагинов в проекте
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage(); // отображение страницы с ошибками
            app.UseStatusCodePages(); //отображение кодов страницы
            app.UseStaticFiles();  // отображение картинок, css
            app.UseMvcWithDefaultRoute(); //отслеживание URL-адреса (без полного адреса - по умолчанию)

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "{controller=Admin}/{action=AdminPage}");
            });
        } //to configure the HTTP request pipeline.


    }
}
