using GeekMapsApi.AggregatesModels;

namespace GeekMapsApi.Infrastructure.Repository.Interfaces;

public interface IEventoRepository
{
    Task PostAsync(Evento model);
}
