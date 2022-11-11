using GeekMapsApi.DTOs;
using GeekMapsApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GeekMapsApi.Controllers;

public class EventoController : BaseController
{
    private readonly IEventoService _eventoService;

    public EventoController(IEventoService eventoService)
    {
        _eventoService = eventoService;
    }

    [HttpPost("/geekMaps/evento")]
    [SwaggerOperation("Insere um novo evento")]
    public async Task<IActionResult> PostAsync([FromBody]EventoDto model)
    {
        try
        {
            await _eventoService.PostAsync(model);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(new List<string> { ex.Message });
        }        
    }
}
