using controle_estoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace controle_estoque.Controllers
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