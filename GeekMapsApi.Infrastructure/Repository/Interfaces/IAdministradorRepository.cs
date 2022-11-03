using GeekMapsApi.AggregatesModels;

namespace GeekMapsApi.Infrastructure.Repository.Interfaces;

public interface IAdministradorRepository
{
    Task PostAsync(Administrador admin);
    Task<Administrador> GetByEmailAsync(string email);
}
