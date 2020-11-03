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
    public class ActivoController : Controller
    {
        private ProyectoContext db = new ProyectoContext();

        // GET: Activo
        public ActionResult Index()
        {
            var activos = db.Activos.Include(a => a.Categoria).Include(a => a.Estado).Include(a => a.Marca).Include(a => a.TipoActivo);
            return View(activos.ToList());
        }

        // GET: Activo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activo activo = db.Activos.Find(id);
            if (activo == null)
            {
                return HttpNotFound();
            }
            return View(activo);
        }

        // GET: Activo/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "NombreCategoria");
            ViewBag.EstadoID = new SelectList(db.Estados, "EstadoID", "NombreEstado");
            ViewBag.MarcaID = new SelectList(db.Marcas, "MarcaID", "NombreMarca");
            ViewBag.TipoActivoID = new SelectList(db.TipoActivos, "TipoActivoID", "NombreTipo");
            return View();
        }

        // POST: Activo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ActivoID,NombreActivo,EstadoID,CategoriaID,NumeroSerie,MarcaID,Modelo,TipoActivoID,FechaAdquisicion,FechaCreacion")] Activo activo)
        {
            if (ModelState.IsValid)
            {
                db.Activos.Add(activo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "NombreCategoria", activo.CategoriaID);
            ViewBag.EstadoID = new SelectList(db.Estados, "EstadoID", "NombreEstado", activo.EstadoID);
            ViewBag.MarcaID = new SelectList(db.Marcas, "MarcaID", "NombreMarca", activo.MarcaID);
            ViewBag.TipoActivoID = new SelectList(db.TipoActivos, "TipoActivoID", "NombreTipo", activo.TipoActivoID);
            return View(activo);
        }

        // GET: Activo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activo activo = db.Activos.Find(id);
            if (activo == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "NombreCategoria", activo.CategoriaID);
            ViewBag.EstadoID = new SelectList(db.Estados, "EstadoID", "NombreEstado", activo.EstadoID);
            ViewBag.MarcaID = new SelectList(db.Marcas, "MarcaID", "NombreMarca", activo.MarcaID);
            ViewBag.TipoActivoID = new SelectList(db.TipoActivos, "TipoActivoID", "NombreTipo", activo.TipoActivoID);
            return View(activo);
        }

        // POST: Activo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ActivoID,NombreActivo,EstadoID,CategoriaID,NumeroSerie,MarcaID,Modelo,TipoActivoID,FechaAdquisicion,FechaCreacion")] Activo activo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "NombreCategoria", activo.CategoriaID);
            ViewBag.EstadoID = new SelectList(db.Estados, "EstadoID", "NombreEstado", activo.EstadoID);
            ViewBag.MarcaID = new SelectList(db.Marcas, "MarcaID", "NombreMarca", activo.MarcaID);
            ViewBag.TipoActivoID = new SelectList(db.TipoActivos, "TipoActivoID", "NombreTipo", activo.TipoActivoID);
            return View(activo);
        }

        // GET: Activo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activo activo = db.Activos.Find(id);
            if (activo == null)
            {
                return HttpNotFound();
            }
            return View(activo);
        }

        // POST: Activo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Activo activo = db.Activos.Find(id);
            db.Activos.Remove(activo);
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
