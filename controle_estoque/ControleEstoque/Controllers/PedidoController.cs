using ControleEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ControleEstoque.Controllers
{
    public class PedidoController : Controller
    {

        List<Pedido> pedidos = new List<Pedido>() {
               new Pedido(){Id= 1, NumeroNota = 13246 },
               new Pedido(){Id = 2 ,NumeroNota = 99999},
               new Pedido(){Id = 3,  NumeroNota = 91279}
            };
        // GET: Pedido
        public ActionResult Pedido()
        {

            return View(pedidos);
        }
    }
}
