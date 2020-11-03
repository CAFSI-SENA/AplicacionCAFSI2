using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AplicacionCAFSI.DAL;
using AplicacionCAFSI.Models;

namespace AplicacionCAFSI.Controllers
{
    public class TipoActivoController : Controller
    {
        private ProyectoContext db = new ProyectoContext();

        // GET: TipoActivo
        public ActionResult Index()
        {
            return View(db.TipoActivos.ToList());
        }

        // GET: TipoActivo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoActivo tipoActivo = db.TipoActivos.Find(id);
            if (tipoActivo == null)
            {
                return HttpNotFound();
            }
            return View(tipoActivo);
        }

        // GET: TipoActivo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoActivo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoActivoID,NombreTipo,EstadoID")] TipoActivo tipoActivo)
        {
            if (ModelState.IsValid)
            {
                db.TipoActivos.Add(tipoActivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoActivo);
        }

        // GET: TipoActivo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoActivo tipoActivo = db.TipoActivos.Find(id);
            if (tipoActivo == null)
            {
                return HttpNotFound();
            }
            return View(tipoActivo);
        }

        // POST: TipoActivo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoActivoID,NombreTipo,EstadoID")] TipoActivo tipoActivo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoActivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoActivo);
        }

        // GET: TipoActivo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoActivo tipoActivo = db.TipoActivos.Find(id);
            if (tipoActivo == null)
            {
                return HttpNotFound();
            }
            return View(tipoActivo);
        }

        // POST: TipoActivo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoActivo tipoActivo = db.TipoActivos.Find(id);
            db.TipoActivos.Remove(tipoActivo);
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
