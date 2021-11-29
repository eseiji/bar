using System;

namespace Bar.Models
{
  public class Mesa
  {
    public int IdMesa { get; set; }
    public int Status { get; set; }
    public string TextoStatus { get; set; }

    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public string Descricao { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorUn { get; set; }
    public string NomeCliente { get; set; }
  }
}