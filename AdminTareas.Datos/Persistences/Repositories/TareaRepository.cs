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

        public async Task<bool> AgregarTarea(Tarea tarea)
        {

            try
            {
                await _context.Tareas.AddAsync(tarea);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creando la tarea: {ex.Message}");
                return false;
            }
        }

        public List<Tarea> ObtenerTareas()
        {
            try
            {
                return _context.Tareas.OrderBy(t => t.FechaCompromiso).ToList();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error recuperando  las tarea: ", ex.Message);
                return new List<Tarea>();

            }
        }

        public async Task<Tarea?> ObtenerPorIdAsync(int id)
        {
            try
            {
                return await _context.Tareas.FindAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error obteniendo la tarea por ID {id}: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> EditarTarea(Tarea tarea)
        {
            try
            {               
                _context.Entry(tarea).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Actualizando la tarea: {ex.Message}");
                return false;
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
