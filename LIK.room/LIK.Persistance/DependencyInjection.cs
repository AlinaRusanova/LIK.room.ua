using LIK.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIK.Persistence
{
   public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<AppDBContent>(options => options
            //                           .UseSqlServer(configuration.GetConnectionString("LIK.roomDB"))
            //                           // .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
            //                           //детальный вывод ошибок EF Core
            //                           .EnableDetailedErrors()
            //                           // вывод приватных данных приложения (таких как сгенерированные строки запроса, параметры этих строк запроса)
            //                           .EnableSensitiveDataLogging());
            //тут необходимо добавить Logger
            //                .UseLoggerFactory(Console.WriteLine,
            //                new[] { DbLoggerCategory.Database.Command.Name },  )) ;

            //   services.AddScoped<IAppDBContent>(provider => provider.GetService<AppDBContent>());   - изменить

            return services;
        }

    }
}
