using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIK.Application.Interfaces;
using LIK.Persistence.Repository;
using LIK.Persistence;


namespace LIK.room
{
    public class Startup
    {
        private IConfigurationRoot _confString;

[Obsolete]
        public Startup(IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder()
                .AddUserSecrets<AppDBContent>()
              //  .SetBasePath(hostEnv.ContentRootPath).AddJsonFile("appsettings.json")
                .Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddTransient<IClothing,ClothingRepository>(); // объединяет класс и интерфейс
            services.AddTransient<IClothingCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();
            //    services.AddScoped<IShopCartItem, ShopCartRepository>();
            services.AddDbContext<AppDBContent>(options => options
                                        .UseSqlServer(_confString.GetConnectionString("LIK.roomDB"))
                                        // .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                                        //детальный вывод ошибок EF Core
                                        .EnableDetailedErrors()
                                        // вывод приватных данных приложения (таких как сгенерированные строки запроса, параметры этих строк запроса)
                                        .EnableSensitiveDataLogging());

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCartRepository.GetCart(sp));
            
            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddMemoryCache();
            services.AddSession();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();

            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
             //  routes.MapRoute(name: "categoryFilter", template: "Clothes/{action}/{category?}", defaults: new { Controller = "Clothes", action = "List" });
            });


            using (var scope = app.ApplicationServices.CreateScope())
            {
            AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            DBObjects.Initial(content);
            }

            
            
        }
    }
}
