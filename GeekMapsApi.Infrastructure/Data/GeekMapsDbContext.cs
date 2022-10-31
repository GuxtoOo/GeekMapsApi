using Microsoft.EntityFrameworkCore;

namespace GeekMapsApi.Infrastructure.Data;

public class GeekMapsDbContext : DbContext
{
    public GeekMapsDbContext(DbContextOptions<GeekMapsDbContext> options) : base(options) { }

    
}
