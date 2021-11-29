namespace Bar.Models
{
  public class Produto
  {
    public int IdProduto { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public int TipoProduto { get; set; }
    public int Estoque { get; set; }
    public int Quantidade { get; set; }
  }
}