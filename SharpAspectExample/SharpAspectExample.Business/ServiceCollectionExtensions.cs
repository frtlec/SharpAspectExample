using Microsoft.Extensions.DependencyInjection;
using SharpAspect;

namespace SharpAspectExample.Business
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServiceDependencies(this IServiceCollection services)
        {

            return services.EnableDynamicProxy();
        }
    }
}

