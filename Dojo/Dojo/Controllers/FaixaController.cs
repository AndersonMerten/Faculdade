using Dojo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// Anderson Iago Merten andersonmerten@gmail.com
namespace Dojo.Controllers
{

    public class FaixaController : Controller
    {
        private ApplicationDbContext _context;
        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Faixa
        public ActionResult Index()
        {
            var ListaFaixas = _context.Faixas.ToList();
            return View(ListaFaixas);
        }
        public ActionResult Details(int id)
        {
            var ListaFaixas = _context.Faixas.ToList();
            return View(ListaFaixas.Find(cliente => cliente.Id == id));
            
        }
    }
}