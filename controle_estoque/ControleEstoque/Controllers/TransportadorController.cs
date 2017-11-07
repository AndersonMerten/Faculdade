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
    public class TransportadorController : Controller
    {
            private ApplicationDbContext _context;
            public TransportadorController()
            {
                  _context = new ApplicationDbContext();
            }

            public ActionResult Transportador()
        {
                  var transportadoras = _context.Transportadoras.ToList();
                  return View(transportadoras);
            }
    }
}
