using Microsoft.Extensions.Configuration;

namespace AdminTareas.Utilidades.Conexion
{
    public static class AppSettings
    {
        private static IConfigurationRoot _config;

        static AppSettings()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string ConnectionString =>
            _config.GetConnectionString("DefaultConnection")!;
    }
}
