using Microsoft.EntityFrameworkCore;
using SegundoParcialWebAdrianLaymeVS.Data;
using SegundoParcialWebAdrianLaymeVS.Models;
using SegundoParcialWebAdrianLaymeVS.Models.DTOs;

namespace SegundoParcialWebAdrianLaymeVS.Services
{
    public class PrioridadService
    {
        private readonly AppDbContext _context;

        public PrioridadService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Prioridad>> ObtenerTodosAsync()
        {
            return await _context.Prioridades.ToListAsync();
        }

        public async Task<Prioridad> RegistrarAsync(RegistrarPrioridadDto dto)
        {
            if (await _context.Prioridades.AnyAsync(r => r.Nombre == dto.Nombre))
                throw new Exception("El nombre de la prioridad ya existe");

            var prioridad = new Prioridad
            {
                Nombre = dto.Nombre
            };

            _context.Prioridades.Add(prioridad);
            await _context.SaveChangesAsync();
            return prioridad;
        }
    }
}
