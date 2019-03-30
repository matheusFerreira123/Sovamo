using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sovamo.Models;

namespace Sovamo.Controllers
{
    public class CadUsuarioController : Controller
    {
        private Context db = new Context();

        // GET: CadUsuario
        public ActionResult Index()
        {
            return View(db.CadUsuario.ToList());
        }

        // GET: CadUsuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadUsuario cadUsuario = db.CadUsuario.Find(id);
            if (cadUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadUsuario);
        }

        // GET: CadUsuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadUsuario/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClienteID,Nome,Email,Telefone,Senha,EstiloMusical")] CadUsuario cadUsuario)
        {
            if (ModelState.IsValid)
            {
                db.CadUsuario.Add(cadUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadUsuario);
        }

        // GET: CadUsuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadUsuario cadUsuario = db.CadUsuario.Find(id);
            if (cadUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadUsuario);
        }

        // POST: CadUsuario/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClienteID,Nome,Email,Telefone,Senha,EstiloMusical")] CadUsuario cadUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadUsuario);
        }

        // GET: CadUsuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadUsuario cadUsuario = db.CadUsuario.Find(id);
            if (cadUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadUsuario);
        }

        // POST: CadUsuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CadUsuario cadUsuario = db.CadUsuario.Find(id);
            db.CadUsuario.Remove(cadUsuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
