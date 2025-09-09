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

using System;
using System.IO;

namespace AdminTareas.Utilidades.Conexion
{
    public static class AppSettings
    {
        public static string ConnectionString
        {
            get
            {
                // Ruta al proyecto AdminTareas.Datos
                var solutionDir = GetSolutionDirectory();
                var dbPath = Path.Combine(solutionDir, "AdminTareas.Datos", "adminTareas.db");

                // Asegura que la ruta exista
                if (!File.Exists(dbPath))
                {
                    // Si no existe, lo crea vacío para que SQLite genere la base
                    Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);
                }

                return $"Data Source={dbPath}";
            }
        }

        // Método para encontrar la raíz del solution, partiendo desde bin
        private static string GetSolutionDirectory()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;

            // Busca hacia arriba hasta encontrar la carpeta que contenga AdminTareas.Datos
            while (!Directory.Exists(Path.Combine(dir, "AdminTareas.Datos")) && dir != Directory.GetDirectoryRoot(dir))
            {
                dir = Directory.GetParent(dir)!.FullName;
            }

            return dir;
        }
    }
}

