using AdminTareas.Modelos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AdminTareas.Datos.Context
{
    public class AdminTareaContext : DbContext
    {

        public AdminTareaContext(DbContextOptions<AdminTareaContext> options):base (options) { }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<EstadoTarea> EstadoTareas { get; set; }
        public DbSet<PrioridadTarea> PrioridadTareas { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "adminTareas.db");
        //        optionsBuilder.UseSqlite($"Data Source={dbPath}");
        //    }
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                var exeBase = AppDomain.CurrentDomain.BaseDirectory;               
                var projectDir = Path.GetFullPath(Path.Combine(exeBase, "..", "..", "..", "..", "AdminTareas.Datos"));               
                var dbPath = Path.Combine(projectDir, "adminTareas.db");              
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
            }
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data para catálogos
            modelBuilder.Entity<EstadoTarea>().HasData(
                new EstadoTarea { Id = 1, Nombre = "PENDIENTE", Descripcion = "Tarea pendiente de iniciar" },
                new EstadoTarea { Id = 2, Nombre = "EN_PROCESO", Descripcion = "Tarea en proceso" },
                new EstadoTarea { Id = 3, Nombre = "FINALIZADA", Descripcion = "Tarea completada" }
            );

            modelBuilder.Entity<PrioridadTarea>().HasData(
                new PrioridadTarea { Id = 1, Nombre = "ALTA", Descripcion = "Prioridad alta" },
                new PrioridadTarea { Id = 2, Nombre = "MEDIA", Descripcion = "Prioridad media" },
                new PrioridadTarea { Id = 3, Nombre = "BAJA", Descripcion = "Prioridad baja" }
            );
        }


    }
}
