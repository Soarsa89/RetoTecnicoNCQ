using System.ComponentModel.DataAnnotations;

namespace AdminTareas.Modelos.Entidades
{
    public class PrioridadTarea
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Descripcion { get; set; }
    }
}
