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
    public class NovedadController : Controller
    {
        private ProyectoContext db = new ProyectoContext();

        // GET: Novedad
        public ActionResult Index()
        {
            var novedades = db.Novedades.Include(n => n.Activo).Include(n => n.TipoNovedad).Include(n => n.Usuario);
            return View(novedades.ToList());
        }

        // GET: Novedad/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novedad novedad = db.Novedades.Find(id);
            if (novedad == null)
            {
                return HttpNotFound();
            }
            return View(novedad);
        }

        // GET: Novedad/Create
        public ActionResult Create()
        {
            ViewBag.ActivoID = new SelectList(db.Activos, "ActivoID", "NombreActivo");
            ViewBag.TipoNovedadID = new SelectList(db.TipoNovedades, "TipoNovedadID", "NombreTipo");
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "NombreUsuario");
            return View();
        }

        // POST: Novedad/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NovedadID,TipoNovedadID,ActivoID,FechaNovedad,Observacion,UsuarioID")] Novedad novedad)
        {
            if (ModelState.IsValid)
            {
                db.Novedades.Add(novedad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActivoID = new SelectList(db.Activos, "ActivoID", "NombreActivo", novedad.ActivoID);
            ViewBag.TipoNovedadID = new SelectList(db.TipoNovedades, "TipoNovedadID", "NombreTipo", novedad.TipoNovedadID);
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "NombreUsuario", novedad.UsuarioID);
            return View(novedad);
        }

        // GET: Novedad/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novedad novedad = db.Novedades.Find(id);
            if (novedad == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActivoID = new SelectList(db.Activos, "ActivoID", "NombreActivo", novedad.ActivoID);
            ViewBag.TipoNovedadID = new SelectList(db.TipoNovedades, "TipoNovedadID", "NombreTipo", novedad.TipoNovedadID);
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "NombreUsuario", novedad.UsuarioID);
            return View(novedad);
        }

        // POST: Novedad/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NovedadID,TipoNovedadID,ActivoID,FechaNovedad,Observacion,UsuarioID")] Novedad novedad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(novedad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActivoID = new SelectList(db.Activos, "ActivoID", "NombreActivo", novedad.ActivoID);
            ViewBag.TipoNovedadID = new SelectList(db.TipoNovedades, "TipoNovedadID", "NombreTipo", novedad.TipoNovedadID);
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "NombreUsuario", novedad.UsuarioID);
            return View(novedad);
        }

        // GET: Novedad/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novedad novedad = db.Novedades.Find(id);
            if (novedad == null)
            {
                return HttpNotFound();
            }
            return View(novedad);
        }

        // POST: Novedad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Novedad novedad = db.Novedades.Find(id);
            db.Novedades.Remove(novedad);
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
