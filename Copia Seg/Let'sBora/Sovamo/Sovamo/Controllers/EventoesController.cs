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
    public class EventoesController : Controller
    {
        private Context db = new Context();

        // GET: Eventoes
        public ActionResult Index()
        {
            return View(db.Eventoes.OrderBy(o => o.Dia));
        }

        public ActionResult Sorteio()
        {
            return View(db.Eventoes.ToList().Where(o => o.Dispsorteio == 0));
        }
        public ActionResult Eletronica()
        {
            return View(db.Eventoes.ToList().Where(o => o.EstiloMusical == EstiloMusical.Eletronica));
        }
        public ActionResult Funk()
        {
            return View(db.Eventoes.ToList().Where(o => o.EstiloMusical == EstiloMusical.Funk));
        }
        public ActionResult Mpb()
        {
            return View(db.Eventoes.ToList().Where(o => o.EstiloMusical == EstiloMusical.MPB));
        }
        public ActionResult Reggae()
        {
            return View(db.Eventoes.ToList().Where(o => o.EstiloMusical == EstiloMusical.Reggae));
        }
        public ActionResult Retro()
        {
            return View(db.Eventoes.ToList().Where(o => o.EstiloMusical == EstiloMusical.Retro));
        }
        public ActionResult Rock()
        {
            return View(db.Eventoes.ToList().Where(o => o.EstiloMusical == EstiloMusical.Rock));
        }
        public ActionResult Sertanejo()
        {
            return View(db.Eventoes.ToList().Where(o => o.EstiloMusical == EstiloMusical.Sertanejo));
        }



        // GET: Eventoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventoes.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        // GET: Eventoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eventoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventoId,Nome,Atracao,EstiloMusical,Descricao,Dia,Dispsorteio")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                db.Eventoes.Add(evento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evento);
        }

        // GET: Eventoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventoes.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        // POST: Eventoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventoId,Nome,Atracao,EstiloMusical,Descricao,Dia,Dispsorteio")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evento);
        }

        // GET: Eventoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventoes.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        // POST: Eventoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evento evento = db.Eventoes.Find(id);
            db.Eventoes.Remove(evento);
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
        [HttpPost]
        public ActionResult Search(FormCollection fc, string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var eventos = db.Eventoes.Include(c => c.Nome).Include(e =>
                e.Nome).Where(c => c.Nome.Contains(searchString)).OrderBy(o => o.Nome);
                return View("Index", eventos.ToList());
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
