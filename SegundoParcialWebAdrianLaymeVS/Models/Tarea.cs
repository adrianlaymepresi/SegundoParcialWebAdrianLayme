using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebAdrianLaymeVS.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Titulo { get; set; } = string.Empty;

        [MaxLength(150)]
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required, MaxLength(50)] // Ejemplos: ToDo, InProgress, Done
        public string Estado { get; set; } = "ToDo";

        [Required]
        public int ResponsableId { get; set; }

        [Required]
        public int PrioridadId { get; set; }
    }
}
