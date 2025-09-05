using AdminTareas.Modelos.Entidades;

namespace AdminTareas.Datos.Persistences.Interfaces
{
    public interface ITareaRepository
    {
        void AgregarTarea(Tarea tarea);
        List<Tarea> ObtenerTareas();
        void EditarTarea(Tarea tarea);
        void EliminarTarea(int id);
    }
}
