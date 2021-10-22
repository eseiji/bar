using System.ComponentModel.DataAnnotations;

namespace Bar.Models
{
  public class UsuarioLoginViewModel
  {
    [Required(ErrorMessage = "Campo obrigatório!")]
    public string Cpf { get; set; }
  }
}