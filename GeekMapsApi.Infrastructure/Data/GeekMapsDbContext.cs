using GeekMapsApi.AggregatesModels;
using GeekMapsApi.Domain.AggregatesModels;
using Microsoft.EntityFrameworkCore;

namespace GeekMapsApi.Infrastructure.Data;

public class GeekMapsDbContext : DbContext
{
    public GeekMapsDbContext(DbContextOptions<GeekMapsDbContext> options) : base(options) { }    

    public DbSet<Administrador> Administrador { get;set; }
    public DbSet<Evento> Evento { get; set; }
}
