using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Avaliacao3bimLP3.Models;
using Avaliacao3BimLP3.ViewModels;

namespace Avaliacao3bimLP3.Controllers;

public class LojaController : Controller
{

    private static List<LojaViewModel> lojas = new List<LojaViewModel> {
        new LojaViewModel(32, "piso 3", "Tênis Brasil", "Aqui você encontra os tênis", true, "tenis@email.com"),
        new LojaViewModel(33, "piso 3", "Lembranças Já", "Vem comprar sua lembrança", true, "lemb@email.com"),
        new LojaViewModel(12, "piso 1", "Sorvetinho Gelado", "Sorvetinho Gelado", false, "sorvet@email.com"),
    };

        public IActionResult DeletarPorId(int id){
        
        foreach (var loja in lojas)
        {
          if(loja.Id  == id){
            lojas.Remove(loja);
          }
        }
        return View();
    }

//listar
    public IActionResult Index()
    {
        return View(LojaController.lojas);
    }

        public IActionResult Cadastro()
    {
        return View();
    }
}
