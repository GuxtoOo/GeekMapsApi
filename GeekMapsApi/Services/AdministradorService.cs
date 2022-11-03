using AutoMapper;
using GeekMapsApi.AggregatesModels;
using GeekMapsApi.DTOs;
using GeekMapsApi.Infrastructure.Repository.Interfaces;
using GeekMapsApi.Services.Interfaces;
using static BCrypt.Net.BCrypt;

namespace GeekMapsApi.Services;

public class AdministradorService : IAdministradorService
{
    private readonly IMapper _mapper;
    private readonly IAdministradorRepository _administradorRepository;

    public AdministradorService(IMapper mapper, IAdministradorRepository administradorRepository)
    {
        _mapper = mapper;
        _administradorRepository = administradorRepository;
    }

    public async Task<AdministradorDto> PostAsync(AdministradorDto model)
    {
        //var email = await _administradorRepository.GetByEmailAsync(model.Email);
        //if (email != null)
        //    throw new Exception("O email informado já está em uso");

        var adm = _mapper.Map<Administrador>(model);

        if (string.IsNullOrEmpty(adm.Email))
            throw new Exception("Dados informados inválidos");
        if (string.IsNullOrEmpty(adm.Senha))
            throw new Exception("Dados informados inválidos");

        try
        {
            adm.Id = 0;
            adm.Senha = HashPassword(adm.Senha, 10);
            await _administradorRepository.PostAsync(adm);
            return model;
        }
        catch
        {
            throw new Exception("Ocorreu um erro ao tentar criar o usuário");
        }        
    }
}
