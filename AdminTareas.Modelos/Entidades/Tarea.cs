using System.ComponentModel.DataAnnotations;

namespace AdminTareas.Modelos.Entidades
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descripcion { get; set; } = string.Empty;

        [Required]
        public string Estado { get; set; } = "PENDIENTE";

        //[Required]
        //public EstadoTarea Estado { get; set; } = EstadoTarea.PENDIENTE;   //Enum

        [Required]
        public string Prioridad { get; set; } = string.Empty;

        [Required]
        public DateTime FechaCompromiso { get; set; }

        [MaxLength(1000)]
        public string? Notas { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
