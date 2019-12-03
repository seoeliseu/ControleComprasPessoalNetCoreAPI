using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "E-mail é um campo obrigatório para login.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [MaxLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
