using Application;
using Microsoft.EntityFrameworkCore;   
using Microsoft.Extensions.Configuration;   
 using Microsoft.Extensions.DependencyInjection;   
   

namespace InfrastructurePersistence
{
    public static class DependencyInjection
    {
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
    services.AddDbContext<ApplicationDbContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("ApplicationConnectionString")));

    services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

     services.AddScoped<ICertificationsRepository, CertificationsRepository>();

     services.AddScoped<ICVsRepository, CVsRepository>();

     services.AddScoped<ICompetencesRepository, CompetencesRepository>();

     services.AddScoped<ICVCompetencesRepository, CVCompetencesRepository>();

     services.AddScoped<ICVLanguesRepository, CVLanguesRepository>();

     services.AddScoped<ILanguesRepository, LanguesRepository>();

     services.AddScoped<IExperiencesRepository, ExperiencesRepository>();

     services.AddScoped<IFormationsRepository, FormationsRepository>();

     services.AddScoped<ILoisirsRepository, LoisirsRepository>();

     services.AddScoped<IProjetsPersonnelsRepository, ProjetsPersonnelsRepository>();

     services.AddScoped<IReferencesContactRepository, ReferencesContactRepository>();

     services.AddScoped<ILogsRepository, LogsRepository>();

    return services;
    }
    }
}
