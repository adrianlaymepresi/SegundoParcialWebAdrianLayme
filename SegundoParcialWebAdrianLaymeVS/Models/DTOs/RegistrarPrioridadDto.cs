using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebAdrianLaymeVS.Models.DTOs
{
    public class RegistrarPrioridadDto
    {

        [Required, MaxLength(50)] // Ejemplos: Baja, Media, Alta
        public string Nombre { get; set; } = string.Empty;
    }
}
