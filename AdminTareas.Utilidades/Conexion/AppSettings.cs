
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
                var solutionDir = GetSolutionDirectory();
                var dbPath = Path.Combine(solutionDir, "AdminTareas.Datos", "adminTareas.db");
                
                if (!File.Exists(dbPath))
                {                    
                    Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);
                }

                return $"Data Source={dbPath}";
            }
        }

      
        private static string GetSolutionDirectory()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
           
            while (!Directory.Exists(Path.Combine(dir, "AdminTareas.Datos")) && dir != Directory.GetDirectoryRoot(dir))
            {
                dir = Directory.GetParent(dir)!.FullName;
            }

            return dir;
        }
    }
}

