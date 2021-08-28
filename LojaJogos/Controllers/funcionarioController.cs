using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaJogos.Models;

namespace LojaJogos.Controllers
{
    public class funcionarioController : Controller
    {
        // GET: funcionario
        public ActionResult Funcionario()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        [HttpPost]
        public ActionResult Funcionario(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                return View("ResultFuncionario", funcionario);
            }
            return View(funcionario);
        }
    }
}