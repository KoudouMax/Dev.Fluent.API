using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dev.Fluent.IoC
{
    public static class DbContextInjector
    {
        public static IServiceCollection InjectSqlServer<TContext>(this IServiceCollection services, string connectionString)
            where TContext: DbContext  {

            services.AddDbContext<TContext>(ctx =>
                ctx.UseSqlServer(
                    connectionString,
                    assembly => assembly.MigrationsAssembly(typeof(TContext).Assembly.FullName))
            );

            services.AddScoped<TContext>();

            return services;
        }
    }
}