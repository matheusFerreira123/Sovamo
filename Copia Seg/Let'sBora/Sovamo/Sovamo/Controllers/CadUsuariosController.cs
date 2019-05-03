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
    public class CadUsuariosController : Controller
    {
        private Context db = new Context();

        // GET: CadUsuarios
        public ActionResult Index()
        {
            return View(db.CadUsuarios.ToList());
        }

        // GET: CadUsuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadUsuario cadUsuario = db.CadUsuarios.Find(id);
            if (cadUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadUsuario);
        }

        // GET: CadUsuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CadUsuarioID,Nome,Email,Telefone,Senha,EstiloMusical")] CadUsuario cadUsuario)
        {
            if (ModelState.IsValid)
            {
                db.CadUsuarios.Add(cadUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadUsuario);
        }

        // GET: CadUsuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadUsuario cadUsuario = db.CadUsuarios.Find(id);
            if (cadUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadUsuario);
        }

        // POST: CadUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CadUsuarioID,Nome,Email,Telefone,Senha,EstiloMusical")] CadUsuario cadUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadUsuario);
        }

        // GET: CadUsuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadUsuario cadUsuario = db.CadUsuarios.Find(id);
            if (cadUsuario == null)
            {
                return HttpNotFound();
            }
            return View(cadUsuario);
        }

        // POST: CadUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CadUsuario cadUsuario = db.CadUsuarios.Find(id);
            db.CadUsuarios.Remove(cadUsuario);
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
