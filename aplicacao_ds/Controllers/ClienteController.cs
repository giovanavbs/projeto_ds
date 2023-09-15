using aplicacao_ds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aplicacao_ds.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View();
        }
        [HttpPost] 
        public ActionResult Index(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", cliente);
            } 
            return View(cliente);
        }
        public ActionResult Resultado(Cliente cliente)
        {
            return View(cliente);
        }
    }
}