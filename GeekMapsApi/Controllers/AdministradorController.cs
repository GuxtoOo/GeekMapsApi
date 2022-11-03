using GeekMapsApi.DTOs;
using GeekMapsApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GeekMapsApi.Controllers;

public class AdministradorController : BaseController
{
    private readonly IAdministradorService _administradorService;

    public AdministradorController(IAdministradorService administradorService)
    {
        _administradorService = administradorService;
    }

    [HttpPost("/geekMaps/adm")]
    [SwaggerOperation("Adiciona um novo administrador")]
    public async Task<IActionResult> PostAsync([FromBody] AdministradorDto request)
    {
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState.Values.SelectMany(v => v.Errors.Select(b => b.ErrorMessage)));
        try
        {
            var response = await _administradorService.PostAsync(request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(new List<string> { ex.Message });
        }        
    }
}
