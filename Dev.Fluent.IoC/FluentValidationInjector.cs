using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Dev.Fluent.IoC
{
    public static class FluentValidationInjector
    {
        #region Static methods
        public static void InjectFluentValidation(this IServiceCollection services)
        {
            // Validate child properties and root collection elements
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
        #endregion
    }
}