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
    [SwaggerOperation("Adiciona um novo evento")]
    public async Task<IActionResult> PostAsync([FromBody] EventoDto request)
    {
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState.Values.SelectMany(v => v.Errors.Select(b => b.ErrorMessage)));
        try
        {
            var response = await _eventoService.PostAsync(request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(new List<string> { ex.Message });
        }        
    }
}
