namespace GeekMapsApi.AggregatesModels;

public class Administrador
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public bool EmailValido { get; set; }

    public string NmCliente { get;set; } = null!;

    public string NrTelefone { get; set; } = null!;
}
