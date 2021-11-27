using System;
using System.Collections.Generic;
using System.Text.Json;
using Bar.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bar.Models
{
  public class PedidoController : Controller
  {
    /*
    SÓ PARA LEMBRAR:

    CRIAR BOTÃO, CHAMAR MÉTODO PARA INCREMENTAR QUANTIDADE.
    PARA CADA ITEM DA LISTA "SELECIONADOS", COMPARAR COM O ID TRAZIDO PELO BOTÃO E ADICIONAR A QUANTIDADE (FEITO)

    FAZER INSERT NO BANCO SÓ DEPOIS DE CONFIMAR NA TELA PEDIDO/CARRINHO (REMOVER REPOSITORY.CREATE DO PEDIDO/CARRINHO E ADICIONAR EM PEDIDO/FECHARpedido)*/
    private IPedidoRepository repository;

    public PedidoController(IPedidoRepository repository)
    {
      this.repository = repository;
    }

    public ActionResult Carrinho()
    {
      if (TempData["selecionados"] != null)
      {
        var selecionados = JsonSerializer.Deserialize<List<Produto>>(TempData["selecionados"] as String);
        repository.Create(selecionados);
        ViewBag.Produtos = selecionados;
        //Console.WriteLine(selecionados);
      }

      return View();
    }

    public void Finalizar()
    {

    }

  }
}