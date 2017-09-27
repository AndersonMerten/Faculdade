using Dojo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dojo.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        private ApplicationDbContext _context;
        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: TipoDeAssociacao
        public ActionResult Index()
        {
            var ListaAssociacoes = _context.TipoDeAssociacoes.ToList();
            return View(ListaAssociacoes);
        }
        public ActionResult Details(int id)
        {
            var TipoDeAssociacoes = _context.TipoDeAssociacoes.ToList();
            return View(TipoDeAssociacoes.Find(cliente => cliente.Id == id));
        }
    }
}