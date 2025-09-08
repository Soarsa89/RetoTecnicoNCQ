using AdminTareas.Datos.Context;
using AdminTareas.Datos.Persistences.Interfaces;
using AdminTareas.Modelos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AdminTareas.Datos.Persistences.Repositories
{
    public class PrioridadTareaRepository : IPrioridadTareaRepository
    {
        private readonly AdminTareaContext _context;

        public PrioridadTareaRepository(AdminTareaContext context)
        {
            _context = context;
        }

        public List<PrioridadTarea> ObtenerPrioridadTarea()
        {
            try
            {
                return _context.PrioridadTareas.ToList();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error recuperando  la Priroridad: ", ex.Message);
                return new List<PrioridadTarea>();

            }
        }
    }
}
