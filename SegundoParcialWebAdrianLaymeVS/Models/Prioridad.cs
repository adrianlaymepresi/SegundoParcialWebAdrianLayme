using System.ComponentModel.DataAnnotations;

namespace SegundoParcialWebAdrianLaymeVS.Models
{
    public class Prioridad
    {
        public int Id { get; set; }

        [Required, MaxLength(50)] // Ejemplos: Baja, Media, Alta
        public string Nombre { get; set; } = string.Empty;

        public List<Tarea> Tareas { get; set; } = new List<Tarea>();
    }
}
