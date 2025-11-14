using Microsoft.AspNetCore.Mvc;
using SegundoParcialWebAdrianLaymeVS.Services;
using SegundoParcialWebAdrianLaymeVS.Models.DTOs;

namespace SegundoParcialWebAdrianLaymeVS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TareaController : ControllerBase
    {
        private readonly TareaService _service;

        public TareaController(TareaService service)
        {
            _service = service;
        }

        [HttpGet("listarTareas")]
        public async Task<IActionResult> Obtener()
        {
            try
            {
                var tareas = await _service.ObtenerTodosAsync();
                return Ok(tareas);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("crearTarea")]
        public async Task<IActionResult> Registrar(RegistrarTareaDto dto)
        {
            try
            {
                var tarea = await _service.RegistrarAsync(dto);
                return Ok(new { mensaje = "tarea registrado", tarea });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPut("editarTarea")]
        public async Task<IActionResult> Actualizar(EditarTareaDto dto)
        {
            try
            {
                var tarea = await _service.ActualizarAsync(dto);
                return Ok(new { mensaje = "Tarea actualizado", tarea });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpDelete("eliminarTarea")]
        public async Task<IActionResult> BorrarFisico(EliminarTareaDto dto)
        {
            try
            {
                var tarea = await _service.BorradoFisicoAsync(dto);
                return Ok(new { mensaje = "Tarea eliminado permanentemente", tarea });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("buscarTareaPorTitulo")]
        public async Task<IActionResult> ObtenerPorId(BuscarTareaDtoTitulo dto)
        {
            try
            {
                var tarea = await _service.BuscarTareaPorTituloAsync(dto);
                return Ok(tarea);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("listarTareaPorMiembro")]
        public async Task<IActionResult> ObtenerPorMiemListarTareaPorMiembroAsync(ListarTareaPorMiembro dto)
        {
            try
            {
                var tarea = await _service.ListarTareaPorMiembroAsync(dto);
                return Ok(tarea);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
