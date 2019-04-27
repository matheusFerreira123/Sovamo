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
    public class CadClientesController : Controller
    {
        private Context db = new Context();

        // GET: CadClientes
        public ActionResult Index()
        {
            return View(db.CadClientes.ToList());
        }

        // GET: CadClientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadCliente cadCliente = db.CadClientes.Find(id);
            if (cadCliente == null)
            {
                return HttpNotFound();
            }
            return View(cadCliente);
        }

        // GET: CadClientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadClientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClienteId,Nome,Cpf,Rg,Telefone,Estado,Cidade,Rua,Numero,Email,Senha")] CadCliente cadCliente)
        {
            if (ModelState.IsValid)
            {
                db.CadClientes.Add(cadCliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadCliente);
        }

        // GET: CadClientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadCliente cadCliente = db.CadClientes.Find(id);
            if (cadCliente == null)
            {
                return HttpNotFound();
            }
            return View(cadCliente);
        }

        // POST: CadClientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClienteId,Nome,Cpf,Rg,Telefone,Estado,Cidade,Rua,Numero,Email,Senha")] CadCliente cadCliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadCliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadCliente);
        }

        // GET: CadClientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadCliente cadCliente = db.CadClientes.Find(id);
            if (cadCliente == null)
            {
                return HttpNotFound();
            }
            return View(cadCliente);
        }

        // POST: CadClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CadCliente cadCliente = db.CadClientes.Find(id);
            db.CadClientes.Remove(cadCliente);
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
