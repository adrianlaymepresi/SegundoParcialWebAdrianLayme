using Microsoft.EntityFrameworkCore;
using SegundoParcialWebAdrianLaymeVS.Models;

namespace SegundoParcialWebAdrianLaymeVS.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Rol> Roles => Set<Rol>();
        public DbSet<Miembro> Miembros => Set<Miembro>();
        public DbSet<Prioridad> Prioridades => Set<Prioridad>();
        public DbSet<Tarea> Tareas => Set<Tarea>();
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
