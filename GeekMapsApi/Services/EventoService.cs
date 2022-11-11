using AutoMapper;
using GeekMapsApi.Domain.AggregatesModels;
using GeekMapsApi.DTOs;
using GeekMapsApi.Infrastructure.Repository.Interfaces;
using GeekMapsApi.Services.Interfaces;

namespace GeekMapsApi.Services
{
    public class EventoService : IEventoService
    {
        private readonly IMapper _mapper;
        private readonly IEventoRepository _eventoRepository;

        public EventoService(IEventoRepository eventoRepository, IMapper mapper)
        {
            _mapper = mapper;
            _eventoRepository = eventoRepository;
        }

        public async Task PostAsync(EventoDto model)
        {
            if (model == null)
                throw new Exception("Não foi inserido nenhum evento.");

            var entity = _mapper.Map<Evento>(model);
            await _eventoRepository.PostAsync(entity);
        }
    }
}
