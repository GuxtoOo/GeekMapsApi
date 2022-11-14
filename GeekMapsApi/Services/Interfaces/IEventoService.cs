using GeekMapsApi.DTOs;

namespace GeekMapsApi.Services.Interfaces;

public interface IEventoService
{
    Task PostAsync(EventoDto request);
    Task<EventoDto> GetAsync(int id);
}
