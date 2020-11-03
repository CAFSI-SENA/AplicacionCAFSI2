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
    public class MovimientoController : Controller
    {
        private ProyectoContext db = new ProyectoContext();

        // GET: Movimiento
        public ActionResult Index()
        {
            var movimientos = db.Movimientos.Include(m => m.TipoMovimiento);
            return View(movimientos.ToList());
        }

        // GET: Movimiento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movimiento movimiento = db.Movimientos.Find(id);
            if (movimiento == null)
            {
                return HttpNotFound();
            }
            return View(movimiento);
        }

        // GET: Movimiento/Create
        public ActionResult Create()
        {
            ViewBag.TipoMovimientoID = new SelectList(db.TipoMovimientos, "TipoMovimientoID", "NombreTipo");
            return View();
        }

        // POST: Movimiento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovimientoID,TipoMovimientoID,FuncionarioID,ActivoID,FechaInicio,FechaFin,Observacion,EstadoID")] Movimiento movimiento)
        {
            if (ModelState.IsValid)
            {
                db.Movimientos.Add(movimiento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoMovimientoID = new SelectList(db.TipoMovimientos, "TipoMovimientoID", "NombreTipo", movimiento.TipoMovimientoID);
            return View(movimiento);
        }

        // GET: Movimiento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movimiento movimiento = db.Movimientos.Find(id);
            if (movimiento == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoMovimientoID = new SelectList(db.TipoMovimientos, "TipoMovimientoID", "NombreTipo", movimiento.TipoMovimientoID);
            return View(movimiento);
        }

        // POST: Movimiento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovimientoID,TipoMovimientoID,FuncionarioID,ActivoID,FechaInicio,FechaFin,Observacion,EstadoID")] Movimiento movimiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movimiento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoMovimientoID = new SelectList(db.TipoMovimientos, "TipoMovimientoID", "NombreTipo", movimiento.TipoMovimientoID);
            return View(movimiento);
        }

        // GET: Movimiento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movimiento movimiento = db.Movimientos.Find(id);
            if (movimiento == null)
            {
                return HttpNotFound();
            }
            return View(movimiento);
        }

        // POST: Movimiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movimiento movimiento = db.Movimientos.Find(id);
            db.Movimientos.Remove(movimiento);
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
