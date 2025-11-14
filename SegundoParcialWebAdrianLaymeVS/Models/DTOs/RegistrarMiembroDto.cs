using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebAdrianLaymeVS.Models.DTOs
{
    public class RegistrarMiembroDto
    {
        [Required]
        public int CarnetIdentidad { get; set; }

        [Required, MaxLength(50)]
        public string Nombres { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        public int RolId { get; set; }
    }
}
