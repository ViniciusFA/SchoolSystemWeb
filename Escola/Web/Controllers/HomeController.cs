using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PrimeiroProjeto.Models;



namespace PrimeiroProjeto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SobreNos()
        {
            ViewBag.Message = "Um pouco sobre nós.";

            return View();
        }

        public ActionResult Register(Professor _usuario)
        {
            ViewBag.Message = "Registre-se. Não paga nada.";

            return View();
        }

        public ActionResult Frequencia(Professor _usuario, Curso _curso)
        {
            ViewBag.Message = "Frequência";

            return View();
        }

        public ActionResult Avaliacoes(Materia _materia)
        {
            ViewBag.Message = "Avaliações";

            return View();
        }

        public ActionResult Calendario()
        {
            ViewBag.Message = "Calendário Semestral";

            return View();
        }

    }

}