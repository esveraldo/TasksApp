using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Domain.Interfaces.Repositories;
using TasksApp.Infraestructure.Data.Contexts;
using TasksApp.Infraestructure.Data.Repositories;

namespace TasksApp.Unit.Tests
{
    public class Setup : Xunit.Di.Setup
    {
        protected override void Configure()
        {
            ConfigureAppConfiguration((hostingContext, config) =>
            {
                bool reloadOnChange = hostingContext.Configuration.GetValue("hostBuilder:reloadConfigOnChange", true);

                if (hostingContext.HostingEnvironment.IsDevelopment())
                    config.AddUserSecrets<Setup>(true, reloadOnChange);

            });

            ConfigureServices((context, services) =>
            {
                //Injetando a connection string na classe SqlServerContext
                services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase(databaseName: "Lotes"));

                services.AddTransient<IUserRepository, UserRepository>();
                services.AddTransient<IUnitOfWork, UnitOfWork>();
                //services.AddTransient<IEmailDomainService, EmailDomainService>();

            });
        }
    }
}
