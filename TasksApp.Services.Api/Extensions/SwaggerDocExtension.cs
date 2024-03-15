using Microsoft.OpenApi.Models;
using System.Reflection;

namespace TasksApp.Services.Api.Extensions
{
    public static class SwaggerDocExtension
    {
        public static IServiceCollection AddSwaggerDoc(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "Desafio EclipseWorks",
                    Description = "Api de tarefas",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Desafio EclipseWorks",
                        Email = "",
                        Url = new Uri("https://eclipseworks.com.br/")
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                options.IncludeXmlComments($"{xmlPath}");
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "DesafioEclipseWorks");
            });

            return app;
        }
    }
}