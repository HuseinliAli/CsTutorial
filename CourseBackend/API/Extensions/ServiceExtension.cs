using DataAccess.Concretes.Contexts;
using DataAccess.Concretes.Managers;
using DataAccess.Contracts;

namespace API.Extensions
{
    public static partial class Extension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            return services;
        }

        public static IServiceCollection AddSql(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddSqlServer<ApplicationContext>(configuration.GetConnectionString("sql"));
            return services;
        }
    }
}
