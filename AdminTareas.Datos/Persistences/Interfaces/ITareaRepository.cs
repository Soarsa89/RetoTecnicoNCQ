using AdminTareas.Modelos.Entidades;

namespace AdminTareas.Datos.Persistences.Interfaces
{
    public interface ITareaRepository
    {
        Task<bool> AgregarTarea(Tarea tarea);
        List<Tarea> ObtenerTareas();
        Task<Tarea?> ObtenerPorIdAsync(int id);
        Task<bool> EditarTarea(Tarea tarea);
        void EliminarTarea(int id);
    }
}
