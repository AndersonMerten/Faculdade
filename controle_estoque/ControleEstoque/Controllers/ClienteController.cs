using ControleEstoque.Models;
using ControleEstoque.ViewModels;
using System.Data.Entity;
using System.Linq;

using System.Web.Mvc;

namespace ControleEstoque.Controllers
{
      public class ClienteController : Controller
      {
            private ApplicationDbContext _context;

            public ClienteController()
            {
                  _context = new ApplicationDbContext();
            }

            public ActionResult Cliente()
            {
                  var clientes = _context.Clientes.ToList();
                  return View(clientes);
            }

            public ActionResult Index()
            {
                  return View();
            }

            public ActionResult Detalhe(int id)
            {
                  var clientes = _context.Clientes.ToList();
                  return View(clientes.Find(cliente => cliente.Id == id));
            }

            //CRUD start here:
            
            [HttpPost]
            public ActionResult Save(Cliente cliente)
            {
                  if (cliente.Id == 0)
                  {
                        this._context.Clientes.Add(cliente);
                  }
                  else
                  {
                        this._context.Entry(cliente).State = EntityState.Modified;
                  }

                  this._context.SaveChanges();

                  return RedirectToAction("Cliente");

            }

            public ActionResult Edit(int id)
            {

                  var cliente = this._context.Clientes.SingleOrDefault(m => m.Id == id);

                  if (cliente == null)
                        return HttpNotFound();



                  var clienteViewModel = new ClienteFormViewModel()
                  {
                        Cliente = cliente
                  };


                  return View("FormCliente", clienteViewModel);
            }

            public ActionResult New()
            {

                  var clienteViewModel = new ClienteFormViewModel();

                  return View("FormCliente", clienteViewModel);

            }
            [HttpPost]
            public ActionResult Delete(int id)
            {
                  var cliente = this._context.Clientes.Find(id);

                  if (cliente != null)
                  {

                        this._context.Clientes.Remove(cliente);
                        this._context.SaveChanges();

                  }

                  return RedirectToAction("Cliente");


            }



            protected override void Dispose(bool disposing)
            {
                  _context.Dispose();
            }
      }
}

