using AdminTareas.Datos.Context;
using AdminTareas.Datos.Persistences.Interfaces;
using AdminTareas.Modelos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AdminTareas.Datos.Persistences.Repositories
{
    public class TareaRepository : ITareaRepository
    {

        

        private readonly AdminTareaContext _context;

        public TareaRepository(AdminTareaContext context)
        {
            _context = context;
        }

        public void AgregarTarea(Tarea tarea)
        {
            try
            {
                _context.Tareas.Add(tarea);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error creando la tarea: ", ex.Message);
            }
        }

        public List<Tarea> ObtenerTareas()
        {
            try
            {
                return _context.Tareas.ToList();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error recuperando  las tarea: ", ex.Message);
                return new List<Tarea>();

            }
        }

        public void EditarTarea(Tarea tarea)
        {
            try
            {
                // Adjunta la entidad y la marca como modificada para que EF Core la actualice.
                _context.Entry(tarea).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // Maneja el conflicto de concurrencia
                Console.WriteLine($"Error de concurrencia al editar la tarea: {ex.Message}");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Error al editar la tarea: {ex.Message}");
            }
        }

        public void EliminarTarea(int id)
        {
            try
            {
                var tarea = _context.Tareas.Find(id);
                if (tarea != null)
                {
                    _context.Tareas.Remove(tarea);
                    _context.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Error al eliminar la tarea: {ex.Message}");
            }
        }
    }
}
