using System.ComponentModel.DataAnnotations;

namespace GeekMapsApi.DTOs
{
    public class AdministradorDto
    {
        public int Id { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "O campo email é obrigatório", AllowEmptyStrings = false)]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "O campo senha é obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,15}$",
            ErrorMessage = "A senha deve conter no mínimo uma letra minuscula, uma maiuscula, um número e de 6 a 15 caractéres")]
        public string Senha { get; set; } = null!;

        public bool EmailValido { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o nome do cliente", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são aceitos no nome")]
        public string NmCliente { get;set; } = null!;

        [Required(ErrorMessage = "Informe um número de telefone", AllowEmptyStrings =false)]
        [StringLength(14, ErrorMessage = "O número de telefone deve conter no máximo 14 caracteres.")]
        public string NrTelefone { get; set; } = null!;
    }
}
