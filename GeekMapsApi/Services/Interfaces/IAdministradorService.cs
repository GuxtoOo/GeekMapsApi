using GeekMapsApi.DTOs;

namespace GeekMapsApi.Services.Interfaces;

public interface IAdministradorService
{
    Task<AdministradorDto> PostAsync(AdministradorDto request);
}
