using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebAdrianLaymeVS.Models.DTOs
{
    public class RegistrarRolDto
    {
        [Required, MaxLength(50)]
        public string NombreRol { get; set; } = string.Empty;
    }

    public class RolIdDto
    {
        public int Id { get; set; }
    }
}
