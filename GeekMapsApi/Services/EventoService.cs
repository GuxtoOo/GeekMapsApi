using AutoMapper;
using GeekMapsApi.AggregatesModels;
using GeekMapsApi.DTOs;
using GeekMapsApi.Infrastructure.Repository.Interfaces;
using GeekMapsApi.Services.Interfaces;

namespace GeekMapsApi.Services;

public class EventoService : IEventoService
{
    private readonly IMapper _mapper;
    private readonly IEventoRepository _eventoService;

    public EventoService(IMapper mapper, IEventoRepository eventoService)
    {
        _mapper = mapper;
        _eventoService = eventoService;
    }

    public async Task PostAsync(EventoDto model)
    {
        if (model == null)
            throw new Exception("Não foi inserido evento nenhum.");

        var entity = _mapper.Map<Evento>(model);
        await _eventoService.PostAsync(entity);
    }
}
