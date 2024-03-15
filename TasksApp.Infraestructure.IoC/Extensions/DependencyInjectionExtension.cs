using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Application.Interfaces;
using TasksApp.Application.Services;
using TasksApp.Domain.Interfaces.Repositories;
using TasksApp.Domain.Interfaces.Services;
using TasksApp.Domain.Services;
using TasksApp.Infraestructure.Data.Repositories;

namespace TasksApp.Infraestructure.IoC.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUserDomainService, UserDomainService>();
            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IProjectDomainService, ProjectDomainService>();
            services.AddScoped<IProjectAppService, ProjectAppService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            return services;
        }
    }
}
