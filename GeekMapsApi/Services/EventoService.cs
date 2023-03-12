using AutoMapper;
using GeekMapsApi.AggregatesModels;
using GeekMapsApi.DTOs;
using GeekMapsApi.Infrastructure.Repository.Interfaces;
using GeekMapsApi.Services.Interfaces;

namespace GeekMapsApi.Services;

public class EventoService : IEventoService
{
    private readonly IMapper _mapper;
    private readonly IEventoRepository _eventoRepository;

    public EventoService(IMapper mapper, IEventoRepository eventoService)
    {
        _mapper = mapper;
        _eventoRepository = eventoService;
    }

    public async Task PostAsync(EventoDto model)
    {
        if (model == null)
            throw new Exception("Não foi inserido evento nenhum.");

        var entity = _mapper.Map<Evento>(model);
        await _eventoRepository.PostAsync(entity);
    }

    public async Task<EventoDto> GetAsync(int id)
    {
        var response = await _eventoRepository.GetAsync(id);
        if (response == null)
            throw new Exception("Não foi encontrado nenhum evento com esse id.");        
        return _mapper.Map<EventoDto>(response);
    }
}
