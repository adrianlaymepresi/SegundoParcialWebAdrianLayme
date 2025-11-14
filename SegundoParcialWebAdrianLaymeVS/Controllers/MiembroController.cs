using Microsoft.AspNetCore.Mvc;
using SegundoParcialWebAdrianLaymeVS.Services;
using SegundoParcialWebAdrianLaymeVS.Models.DTOs;

namespace SegundoParcialWebAdrianLaymeVS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MiembroController : ControllerBase
    {
        private readonly MiemrboService _service;

        public MiembroController(MiemrboService service)
        {
            _service = service;
        }

        [HttpGet("obtenerMiembros")]
        public async Task<IActionResult> Obtener()
        {
            try
            {
                var miembros = await _service.ObtenerTodosAsync();
                return Ok(miembros);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("registrarMiembro")]
        public async Task<IActionResult> Registrar(RegistrarMiembroDto dto)
        {
            try
            {
                var miembro = await _service.RegistrarAsync(dto);
                return Ok(new { mensaje = "Usuario registrado", miembro });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
