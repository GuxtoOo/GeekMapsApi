using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GeekMapsApi.DTOs;

public class EventoDto
{
    [JsonIgnore]
    public int Id { get; set; }
    [Required]
    public string? NomeEvento { get; set; }
    public int LocalEventoId { get; set; }
}
