using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaJogos.Models;

namespace LojaJogos.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cliente()
        {
            var cliente = new Cliente();
            return View(cliente);
        }
        [HttpPost]
        public ActionResult Cliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("ResultCliente", cliente);
            }
            return View(cliente);
        }
    }
}