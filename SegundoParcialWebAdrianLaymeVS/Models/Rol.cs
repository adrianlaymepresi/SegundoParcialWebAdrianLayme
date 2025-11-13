using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebAdrianLaymeVS.Models
{
    public class Rol
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string NombreRol { get; set; } = string.Empty;

        public List<Miembro> Miembros { get; set; } = new List<Miembro>();
    }
}
