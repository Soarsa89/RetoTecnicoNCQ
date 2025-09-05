using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AdminTareas.Datos.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AdminTareaContext>
    {
        public AdminTareaContext CreateDbContext(string[] args)
        {
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\AdminTareas");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath) 
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AdminTareaContext>();
            optionsBuilder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));

            return new AdminTareaContext(optionsBuilder.Options);
        }
    }
}
