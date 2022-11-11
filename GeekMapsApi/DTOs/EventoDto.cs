using System.ComponentModel.DataAnnotations;

namespace GeekMapsApi.DTOs
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string? NomeEvento { get; set; }
        public int IdLocalEvento { get; set; }
    }
}
