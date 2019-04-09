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
    public class CadEstabelecimentoesController : Controller
    {
        private Context db = new Context();

        // GET: CadEstabelecimentoes
        public ActionResult Index()
        {
            return View(db.CadEstabelecimentoes.ToList());
        }

        // GET: CadEstabelecimentoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadEstabelecimento cadEstabelecimento = db.CadEstabelecimentoes.Find(id);
            if (cadEstabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(cadEstabelecimento);
        }

        // GET: CadEstabelecimentoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadEstabelecimentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstabelecimentoId,Nome,Razao,CpfCliente,Cnpj,Endereço,Telefone,Descricão,horario,Situacao")] CadEstabelecimento cadEstabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.CadEstabelecimentoes.Add(cadEstabelecimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadEstabelecimento);
        }

        // GET: CadEstabelecimentoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadEstabelecimento cadEstabelecimento = db.CadEstabelecimentoes.Find(id);
            if (cadEstabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(cadEstabelecimento);
        }

        // POST: CadEstabelecimentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstabelecimentoId,Nome,Razao,CpfCliente,Cnpj,Endereço,Telefone,Descricão,horario,Situacao")] CadEstabelecimento cadEstabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadEstabelecimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadEstabelecimento);
        }

        // GET: CadEstabelecimentoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadEstabelecimento cadEstabelecimento = db.CadEstabelecimentoes.Find(id);
            if (cadEstabelecimento == null)
            {
                return HttpNotFound();
            }
            return View(cadEstabelecimento);
        }

        // POST: CadEstabelecimentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CadEstabelecimento cadEstabelecimento = db.CadEstabelecimentoes.Find(id);
            db.CadEstabelecimentoes.Remove(cadEstabelecimento);
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
