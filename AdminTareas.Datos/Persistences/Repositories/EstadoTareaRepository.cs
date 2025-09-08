using AdminTareas.Datos.Context;
using AdminTareas.Datos.Persistences.Interfaces;
using AdminTareas.Modelos.Entidades;

namespace AdminTareas.Datos.Persistences.Repositories
{
    public class EstadoTareaRepository : IEstadoTareaRespository
    {
        private readonly AdminTareaContext _context;

        public EstadoTareaRepository(AdminTareaContext context)
        {
            _context = context;
        }

        public List<EstadoTarea> ObtenerEstadoTarea()
        {
            try
            {
                return _context.EstadoTareas.ToList();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error recuperando  las tarea: ", ex.Message);
                return new List<EstadoTarea>();

            }
        }
    }
}
