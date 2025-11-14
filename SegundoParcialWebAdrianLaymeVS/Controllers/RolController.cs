using Microsoft.AspNetCore.Mvc;
using SegundoParcialWebAdrianLaymeVS.Services;
using SegundoParcialWebAdrianLaymeVS.Models.DTOs;

namespace SegundoParcialWebAdrianLaymeVS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolController : ControllerBase
    {
        private readonly RolService _service;

        public RolController(RolService service)
        {
            _service = service;
        }

        [HttpGet("obtenerRoles")]
        public async Task<IActionResult> Obtener()
        {
            try
            {
                var roles = await _service.ObtenerTodosAsync();
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("registrarRol")]
        public async Task<IActionResult> Registrar(RegistrarRolDto dto)
        {
            try
            {
                var rol = await _service.RegistrarAsync(dto);
                return Ok(new { mensaje = "Rol registrado", rol });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
