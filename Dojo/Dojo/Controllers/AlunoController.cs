using Dojo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dojo.Controllers
{
    public class AlunoController : Controller
    {
        private ApplicationDbContext _context;
        public AlunoController()
        {
            _context = new ApplicationDbContext();
            _context.TipoDeAssociacoes.Include(a => a.TipoDeAssociacao).ToList();
            _context.Alunos.Include(e => e.Faixa).ToList();
        }
        // GET: Aluno
        public ActionResult Index()
        {

            var ListaAlunos = _context.Alunos.ToList();
            return View(ListaAlunos);

        }
        public ActionResult Details(int id)
        {
            var ListaAlunos = this._context.Alunos.ToList();
            return View(ListaAlunos.Find(cliente => cliente.Id == id));
        }
    }
}