//using Microsoft.Extensions.Configuration;

//namespace AdminTareas.Utilidades.Conexion
//{
//    public static class AppSettings
//    {
//        private static IConfigurationRoot _config;

//        static AppSettings()
//        {
//            _config = new ConfigurationBuilder()
//                .SetBasePath(Directory.GetCurrentDirectory())
//                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//                .Build();
//        }

//        public static string ConnectionString =>
//            _config.GetConnectionString("DefaultConnection")!;
//    }
//}
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AdminTareas.Utilidades.Conexion
{
    public static class AppSettings
    {
        private static IConfigurationRoot _config;

        static AppSettings()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
        }

        public static string ConnectionString
        {
            get
            {
                
                var basePath = AppDomain.CurrentDomain.BaseDirectory;                
                var dbPath = Path.Combine(basePath, "adminTareas.db");                
                var defaultConnection = _config.GetConnectionString("DefaultConnection");                
                return File.Exists(dbPath) ? $"Data Source={dbPath}" : defaultConnection!;
            }
        }
    }
}
