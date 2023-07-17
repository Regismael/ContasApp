using System.ComponentModel.DataAnnotations;

namespace ContasApp.Presentation.Models
{
    public class UsuariosAlterarSenhaViewModel
    {
        [Required(ErrorMessage = "Por favor, informe a sua senha atual.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
        ErrorMessage = "Informe uma senha com letras maísculas, letras minúsculas, " +
        "números, símbolos e no mínimo 8 caracteres.")]
        public string? SenhaAtual { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
        ErrorMessage = "Informe uma senha com letras maísculas, letras minúsculas," +
        "números, símbolos e no mínimo 8 caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a nova senha.")]
        public string? NovaSenha { get; set; }

        [Compare("NovaSenha", ErrorMessage ="Senhas não conferem.")]
        [Required(ErrorMessage = "Por favor, confirme a nova senha.")]
        public string? NovaSenhaConfirmacao { get; set; }
    }
}
