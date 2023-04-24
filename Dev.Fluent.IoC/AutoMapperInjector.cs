using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Dev.Fluent.IoC
{
    public static class AutoMapperInjector
    {
        public static void InjectAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        } 
    }
}
