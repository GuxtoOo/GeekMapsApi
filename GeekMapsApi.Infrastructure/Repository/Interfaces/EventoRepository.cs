using GeekMapsApi.Domain.AggregatesModels;
using GeekMapsApi.Infrastructure.Data;

namespace GeekMapsApi.Infrastructure.Repository.Interfaces;

public class EventoRepository : IEventoRepository
{
    private readonly GeekMapsDbContext _mapsDbContext;

    public EventoRepository(GeekMapsDbContext mapsDbContext)
    {
        _mapsDbContext = mapsDbContext;
    }

    public async Task PostAsync(Evento entity)
    {
        await _mapsDbContext.Evento.AddAsync(entity);
        await _mapsDbContext.SaveChangesAsync();
    }
}
