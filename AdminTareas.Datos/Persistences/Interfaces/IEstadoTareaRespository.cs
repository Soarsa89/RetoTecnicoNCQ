using AdminTareas.Modelos.Entidades;

namespace AdminTareas.Datos.Persistences.Interfaces
{
    public interface IEstadoTareaRespository
    {
        List<EstadoTarea> ObtenerEstadoTarea();
    }
}
