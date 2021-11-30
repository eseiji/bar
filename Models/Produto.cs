using System;

namespace Bar.Models
{
  public class Produto
  {
    public int IdProduto { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public int TipoProduto { get; set; }
    public int Estoque { get; set; }
    public DateTime DataInclusao { get; set; }
    public int Status { get; set; }
    public int Quantidade { get; set; }
  }
}