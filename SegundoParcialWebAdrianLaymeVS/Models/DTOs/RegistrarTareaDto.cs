using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebAdrianLaymeVS.Models.DTOs
{
    public class RegistrarTareaDto
    {
        [Required, MaxLength(50)]
        public string Titulo { get; set; } = string.Empty;

        [MaxLength(150)]
        public string Descripcion { get; set; } = string.Empty;

        [Required]
        public int ResponsableId { get; set; }

        [Required]
        public int PrioridadId { get; set; }
    }

    public class EditarTareaDto
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Titulo { get; set; } = string.Empty;

        [MaxLength(150)]
        public string Descripcion { get; set; } = string.Empty;

        [Required, MaxLength(50)] // Ejemplos: ToDo, InProgress, Done
        public string Estado { get; set; } = string.Empty;

        [Required]
        public int ResponsableId { get; set; }

        [Required]
        public int PrioridadId { get; set; }
    }

    public class EliminarTareaDto
    {
        public int Id { get; set; }
    }

    public class BuscarTareaDtoTitulo
    {
        [Required, MaxLength(50)]
        public string Titulo { get; set; } = string.Empty;
    }

    public class ListarTareaPorMiembro
    {
        [Required]
        public int ResponsableId { get; set; }
    }
}
