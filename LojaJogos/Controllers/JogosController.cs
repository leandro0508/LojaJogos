using LojaJogos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaJogos.Controllers
{
    public class JogosController : Controller
    {
        // GET: Jogos
        public ActionResult Jogos()
        {
            var jogos = new Jogos(); // aqui criamos o projeto
            return View(jogos); // Retornamos para a view dados
        }
        [HttpPost]
        public ActionResult Jogos(Jogos jogos)
        {
            if (ModelState.IsValid) // Validamos o estado
            {
                return View("ResultJogos", jogos);
            }
            return View(jogos);
        }

    }
}