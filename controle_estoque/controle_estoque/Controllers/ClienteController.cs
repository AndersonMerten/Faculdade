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
               new Cliente(){Id = 1, Nome = "Anderson", Cpf="888,888,888-77", Fone="3374-0218" },
               new Cliente(){Id = 2 , Nome = "Will", Cpf="666,666,666-77", Fone="3374-199"},
               new Cliente(){Id = 3, Nome = "Igor", Cpf="111,888,111-77", Fone="3333-0218"}
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