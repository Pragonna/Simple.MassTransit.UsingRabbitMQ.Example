
using Business.Models;
using Business.RabbitMQ.Producer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.Configure<RabbitMQOptions>(configuration.GetSection(nameof(RabbitMQOptions)));
            services.AddScoped<IRabbitMQConnection, RabbitMQConnection>();

            return services;
        } 
    }
}
