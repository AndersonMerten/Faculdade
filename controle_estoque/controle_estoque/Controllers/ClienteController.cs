using controle_estoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace controle_estoque.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        List<Cliente> clientes = new List<Cliente>() {
               new Cliente(){Id = 1, Nome = "Anderson" },
               new Cliente(){Id = 2 , Nome = "Will"},
               new Cliente(){Id = 3, Nome = "Igor"}
            };
        public ActionResult Cliente()
        {
            
            return View(clientes);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detalhe(int id)
        {
            if (id > clientes.Count) return HttpNotFound();

            return View(clientes.Find(cliente => cliente.Id == id));
        }
    }
}