using GeekMapsApi.AggregatesModels;
using GeekMapsApi.Infrastructure.Data;
using GeekMapsApi.Infrastructure.Repository.Interfaces;

namespace GeekMapsApi.Infrastructure.Repository;

public class EventoRepository : IEventoRepository
{
    private readonly GeekMapsDbContext _geekMapsDb;

    public EventoRepository(GeekMapsDbContext geekMapsDb)
    {
        _geekMapsDb = geekMapsDb;
    }

    public async Task PostAsync(Evento evento)
    {
        _geekMapsDb.Evento.Add(evento);
        await _geekMapsDb.SaveChangesAsync();
    }
}
