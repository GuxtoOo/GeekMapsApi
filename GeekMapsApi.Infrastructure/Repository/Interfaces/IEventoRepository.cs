using GeekMapsApi.Domain.AggregatesModels;

namespace GeekMapsApi.Infrastructure.Repository.Interfaces;

public interface IEventoRepository
{
    Task PostAsync(Evento entity);
}
