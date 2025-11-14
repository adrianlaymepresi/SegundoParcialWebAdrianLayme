using Microsoft.AspNetCore.Mvc;
using SegundoParcialWebAdrianLaymeVS.Services;
using SegundoParcialWebAdrianLaymeVS.Models.DTOs;

namespace SegundoParcialWebAdrianLaymeVS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrioridadController : ControllerBase
    {
        private readonly PrioridadService _service;

        public PrioridadController(PrioridadService service)
        {
            _service = service;
        }

        [HttpGet("obtenerPrioridades")]
        public async Task<IActionResult> Obtener()
        {
            try
            {
                var prioridades = await _service.ObtenerTodosAsync();
                return Ok(prioridades);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("registrarPrioridad")]
        public async Task<IActionResult> Registrar(RegistrarPrioridadDto dto)
        {
            try
            {
                var prioridad = await _service.RegistrarAsync(dto);
                return Ok(new { mensaje = "Prioridad registrado", prioridad });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
