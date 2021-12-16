using System.ComponentModel.DataAnnotations;

namespace Bar.Models
{
  public class Usuario
  {
    public string Nome { get; set; }
    public int IdUsuario { get; set; }
    public string Cpf { get; set; }
    public string Tipo { get; set; }
  }
}