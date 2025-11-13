using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebAdrianLaymeVS.Models.DTOs
{
    public class RegistrarRolDto
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string NombreRol { get; set; } = string.Empty;
    }
}
