using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebAdrianLaymeVS.Models
{
    public class Miembro
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nombres { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        public int RolId { get; set; }

        public List<Tarea> Tareas { get; set; } = new List<Tarea>();
    }
}
