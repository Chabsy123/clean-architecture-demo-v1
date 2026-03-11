using clean_architecture_demo_v1.Core.Interfaces;
using clean_architecture_demo_v1.Framing.Data;
using clean_architecture_demo_v1.Framing.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace clean_architecture_demo_v1.Framing
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddFramingDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=.;Database=CleanV1APIDb;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
