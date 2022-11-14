using AutoMapper;
using GeekMapsApi.AggregatesModels;
using GeekMapsApi.DTOs;
using System.Reflection;

namespace GeekMapsApi.Configurations;

public static class AutoMapperConfig
{
    public static IServiceCollection AddAutoMapperConfig(this IServiceCollection services)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        services.AddAutoMapper(assembly);

        return services;
    }
}

//Maping Routes
public class AutoMapperFastMapper : Profile
{
    public AutoMapperFastMapper()
    {
        CreateMap<Administrador, AdministradorDto>().ReverseMap();
        CreateMap<Evento, EventoDto>().ReverseMap();
    }
}
