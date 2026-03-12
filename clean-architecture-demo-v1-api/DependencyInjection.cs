using clean_architecture_demo_v1.App;
using clean_architecture_demo_v1.Core;
using clean_architecture_demo_v1.Framing;

namespace clean_architecture_demo_v1_api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI()
                .AddFramingDI()
                .AddCoreDI(configuration);

            return services;
        }
    }
}
