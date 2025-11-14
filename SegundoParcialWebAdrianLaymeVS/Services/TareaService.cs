using Microsoft.EntityFrameworkCore;
using SegundoParcialWebAdrianLaymeVS.Data;
using SegundoParcialWebAdrianLaymeVS.Models;
using SegundoParcialWebAdrianLaymeVS.Models.DTOs;

namespace SegundoParcialWebAdrianLaymeVS.Services
{
    public class TareaService
    {
        private readonly AppDbContext _context;

        public TareaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tarea>> ObtenerTodosAsync()
        {
            return await _context.Tareas.ToListAsync();
        }

        public async Task<Tarea> RegistrarAsync(RegistrarTareaDto dto)
        {        
            var tarea = new Tarea
            {
                Titulo = dto.Titulo,
                Descripcion = dto.Descripcion,
                ResponsableId = dto.ResponsableId,
                PrioridadId = dto.PrioridadId
            };

            _context.Tareas.Add(tarea);
            await _context.SaveChangesAsync();
            return tarea;
        }

        public async Task<Tarea> ActualizarAsync(EditarTareaDto dto)
        {
            var tarea = await _context.Tareas.FindAsync(dto.Id);
            if (tarea == null)
                throw new Exception("Usuario no encontrado");

            tarea.Titulo = dto.Titulo;
            tarea.Descripcion = dto.Descripcion;
            tarea.Estado = dto.Estado;

            await _context.SaveChangesAsync();
            return tarea;
        }

        public async Task<Tarea> BorradoFisicoAsync(EliminarTareaDto dto)
        {
            var tarea = await _context.Tareas.FindAsync(dto.Id);
            if (tarea == null)
                throw new Exception("Tarea no encontrado");

            _context.Tareas.Remove(tarea);
            await _context.SaveChangesAsync();
            return tarea;
        }

        public async Task<Tarea> BuscarTareaPorTituloAsync(BuscarTareaDtoTitulo dto)
        {
            var tarea = await _context.Tareas.FindAsync(dto.Titulo);
            if (tarea == null)
                throw new Exception("Tarea no encontrada con ese titulo");

            return tarea;
        }

        public async Task<Tarea> ListarTareaPorMiembroAsync(ListarTareaPorMiembro dto)
        {
            var tarea = await _context.Tareas.FindAsync(dto.ResponsableId);
            if (tarea == null)
                throw new Exception("Tarea no encontrada con ese titulo");

            return tarea;
        }
    }
}
