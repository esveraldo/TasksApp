using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp.Infraestructure.IoC.Extensions
{
    public static class AutoMaperExtension
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
