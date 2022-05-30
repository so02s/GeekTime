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
using Microsoft.EntityFrameworkCore;
using GeekTime.Site_Data;

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
            services.AddDbContext<GeekTimeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("GeekTimeDBConnection"))); //���������� ����������� � �������
            services.AddControllersWithViews();
            services.AddMvc(option => option.EnableEndpointRouting = false);// ��������� MVC
            services.AddTransient<IAdminManager, AdminManager>();
        } //��� ����������� �������� � �������
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage(); // ����������� �������� � ��������
            app.UseStatusCodePages(); //����������� ����� ��������
            app.UseStaticFiles();  // ����������� ��������, css
            app.UseMvcWithDefaultRoute(); //������������ URL-������ (��� ������� ������ - �� ���������)

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "{controller=AdminController}/{action=AdminPage}");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "contact",
                template: "{controller=ContactController}/{action=ContactPage}");
            });
            
            SeedData.Initialize(app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope().ServiceProvider);  //���������� �������������� �������������, ����� Site_Data -> SeedData
            } //to configure the HTTP request pipeline.


    }
}
