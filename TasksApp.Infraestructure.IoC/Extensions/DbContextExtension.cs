﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TasksApp.Infraestructure.Data.Contexts;

namespace TasksApp.Infraestructure.IoC.Extensions
{
    public static class DbContextExtension
    {
        public static IServiceCollection AddDbContextConfig
            (this IServiceCollection services, IConfiguration configuration)
        {

            //capturando o parâmetro DatabaseProvider
            var databaseProvider = configuration.GetSection("DatabaseProvider").Value;

            //verificando o tipo de provider de banco de dados
            switch (databaseProvider)
            {
                case "SqlServer":
                    services.AddDbContext<DataContext>(options => {
                        options.UseSqlServer(configuration.GetConnectionString("BDServicoDeEmail"));
                    });
                    break;

                case "InMemory":
                    services.AddDbContext<DataContext>(options => {
                        options.UseInMemoryDatabase(databaseName: "BDEmailsAPI");
                    });
                    break;
            }

            return services;
        }
    }
}
