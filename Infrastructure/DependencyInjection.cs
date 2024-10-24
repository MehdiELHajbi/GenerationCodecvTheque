using Application.Contracts.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<ICsvExporter, CsvExporter>();
            services.AddTransient(typeof(IFLog<>), typeof(FLog<>));
            //services.AddTransient<IEmailService, EmailService>();

            return services;
        }


    }

}
