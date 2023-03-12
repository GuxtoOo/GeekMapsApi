using GeekMapsApi.AggregatesModels;
using GeekMapsApi.Infrastructure.Data;
using GeekMapsApi.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

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

    public async Task<Evento> GetAsync(int id)
    {
        var entity =  await _geekMapsDb.Evento
            .Where(s => s.Id == id)
            .FirstOrDefaultAsync();
        return entity;
    }    
}
