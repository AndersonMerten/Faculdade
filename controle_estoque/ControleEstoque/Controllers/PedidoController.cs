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
            private ApplicationDbContext _context;
            public PedidoController()
            {
                  _context = new ApplicationDbContext();
            }

            public ActionResult Pedido()
        {
                  var produtos = _context.Produtos.ToList();
                  return View(produtos);
            }
            public ActionResult Index()
            {
                  return View();
            }
      }
}





