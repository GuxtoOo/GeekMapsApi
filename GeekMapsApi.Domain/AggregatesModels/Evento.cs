namespace GeekMapsApi.AggregatesModels;

public class Evento
{
    public int Id { get; set; }
    public string NomeEvento { get; set; } = null!;
    public int LocalEventoId { get; set; }
}
