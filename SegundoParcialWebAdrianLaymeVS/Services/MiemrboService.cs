using Microsoft.EntityFrameworkCore;
using SegundoParcialWebAdrianLaymeVS.Data;
using SegundoParcialWebAdrianLaymeVS.Models;
using SegundoParcialWebAdrianLaymeVS.Models.DTOs;

namespace SegundoParcialWebAdrianLaymeVS.Services
{
    public class MiemrboService
    {
        private readonly AppDbContext _context;

        public MiemrboService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Miembro>> ObtenerTodosAsync()
        {
            return await _context.Miembros.ToListAsync();
        }

        public async Task<Miembro> RegistrarAsync(RegistrarMiembroDto dto)
        {
            if (await _context.Miembros.AnyAsync(r => r.CarnetIdentidad == dto.CarnetIdentidad))
                throw new Exception("El carnet del miembro ya existe");

            var miembro = new Miembro
            {
                CarnetIdentidad = dto.CarnetIdentidad,
                Nombres = dto.Nombres,
                Apellidos = dto.Apellidos,
                RolId = dto.RolId
            };

            _context.Miembros.Add(miembro);
            await _context.SaveChangesAsync();
            return miembro;
        }
    }
}
