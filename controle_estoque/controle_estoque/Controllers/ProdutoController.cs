﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ControleEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Produto()
        {
            return View();
        }
    }
}
