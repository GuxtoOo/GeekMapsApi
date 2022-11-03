using GeekMapsApi.AggregatesModels;
using GeekMapsApi.Infrastructure.Data;
using GeekMapsApi.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GeekMapsApi.Infrastructure.Repository;

public class AdministradorRepository : IAdministradorRepository
{
    private readonly GeekMapsDbContext _geekMapsDb;

    public AdministradorRepository(GeekMapsDbContext geekMapsDb)
    {
        _geekMapsDb = geekMapsDb;
    }

    public async Task<Administrador> GetByEmailAsync(string email)
    {
        var entity = await _geekMapsDb.Administrador
            .Where(s => s.Email == email)
            .FirstOrDefaultAsync();
        return entity;
    }

    public async Task PostAsync(Administrador admin)
    {
        _geekMapsDb.Administrador.Add(admin);
        await _geekMapsDb.SaveChangesAsync();
    }
}
