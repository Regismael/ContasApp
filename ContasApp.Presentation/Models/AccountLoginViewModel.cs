using System.ComponentModel.DataAnnotations;

namespace ContasApp.Presentation.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountLoginViewModel
    {
        [EmailAddress(ErrorMessage ="Por favor, informe um endereço de email, válido.")]
        [Required(ErrorMessage = "Por favor, informe o seu email de acesso.")]
        public string? Email { get; set; }

        [MinLength(8, ErrorMessage ="Por favor, informe, no mínimo, {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o sua senha de acesso.")]
        public string? Senha { get; set; }

    }
}
