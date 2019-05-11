using Sovamo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Data;
using System.Data.Entity;
using System.Web.Mvc;
using Sovamo.Models;

namespace Sovamo.Controllers
{
    public class PublicoController : Controller
    {
        // GET: Publico
        public ActionResult Logar()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Logar(string email, string senha)
        {
           
            if (Funcoes.AutenticarUsuario(email, senha) == false)
            {
                ViewBag.Error = "Nome de usuário e/ou senha inválida";
                return View();
            }
            var myView = View();
            myView.MasterName = "~/Views/Shared/_LayoutCliente.cshtml";
            return myView;

        }
        public ActionResult AcessoNegado()
        {
            using (Context c = new Context())
            {
                return View();
            }
        }
        public ActionResult Logoff()
        {
            Sovamo.Repositories.Funcoes.Deslogar();
            return RedirectToAction("Logar", "Publico");
        }

    }
}