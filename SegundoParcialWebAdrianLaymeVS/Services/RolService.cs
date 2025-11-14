using Microsoft.EntityFrameworkCore;
using SegundoParcialWebAdrianLaymeVS.Data;
using SegundoParcialWebAdrianLaymeVS.Models;
using SegundoParcialWebAdrianLaymeVS.Models.DTOs;

namespace SegundoParcialWebAdrianLaymeVS.Services
{
    public class RolService
    {
        private readonly AppDbContext _context;

        public RolService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Rol>> ObtenerTodosAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Rol> RegistrarAsync(RegistrarRolDto dto)
        {
            if (await _context.Roles.AnyAsync(r => r.NombreRol == dto.NombreRol))
                throw new Exception("El nombre del rol ya existe");

            var rol = new Rol
            {
                NombreRol = dto.NombreRol
            };

            _context.Roles.Add(rol);
            await _context.SaveChangesAsync();
            return rol;
        }
    }
}
