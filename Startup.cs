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
            string connection = Configuration.GetConnectionString("GeekTimeDBConnection"); //����������� � ��
            services.AddDbContext<GeekTimeContext>(options => options.UseSqlServer(connection)); //���������� ���������
            services.AddControllersWithViews();
            services.AddMvc(option => option.EnableEndpointRouting = false);// ��������� MVC

            //����� ��������
            services.AddTransient<IAdminManager, AdminManager>();
            services.AddTransient<IEventManager, EventManager>();
            services.AddTransient<IBoardGameManager, BoardGameManager>();
            services.AddTransient<IComicManager, ComicManager>();
            services.AddTransient<IConsoleGameManager, ConsoleGameManager>();
            services.AddTransient<IContactManager, ContactManager>();
            services.AddTransient<IPostManager, PostManager>();
            services.AddTransient<IRateManager, RateManager>();
            services.AddTransient<IRoomManager, RoomManager>();
            services.AddTransient<ITimetableRentManager, TimetableRentManager>();
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
                name: "event",
                template: "{controller=EventController}/{action=EventPage}");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "contact",
                template: "{controller=ContactController}/{action=ContactPage}");
            });
            
            } //to configure the HTTP request pipeline.


    }
}
