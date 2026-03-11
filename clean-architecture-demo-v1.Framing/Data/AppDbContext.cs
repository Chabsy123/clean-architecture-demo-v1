using clean_architecture_demo_v1.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace clean_architecture_demo_v1.Framing.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
