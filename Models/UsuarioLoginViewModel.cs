using System.ComponentModel.DataAnnotations;

namespace Bar.Models
{
  public class UsuarioLoginViewModel
  {
    [Required(ErrorMessage = "Informe seu CPF para continuar")]
    public string Cpf { get; set; }
  }
}