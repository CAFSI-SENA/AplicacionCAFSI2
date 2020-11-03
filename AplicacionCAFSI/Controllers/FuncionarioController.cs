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
    public class FuncionarioController : Controller
    {
        private ProyectoContext db = new ProyectoContext();

        // GET: Funcionario
        public ActionResult Index()
        {
            var funcionarios = db.Funcionarios.Include(f => f.Area).Include(f => f.Genero).Include(f => f.TipoIdentificacion);
            return View(funcionarios.ToList());
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = db.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            ViewBag.AreaID = new SelectList(db.Areas, "AreaID", "NombreArea");
            ViewBag.GeneroID = new SelectList(db.Generos, "GeneroID", "NombreGenero");
            ViewBag.TipoIdentificacionID = new SelectList(db.TipoIdentificaciones, "TipoIdentificacionID", "NombreTipo");
            return View();
        }

        // POST: Funcionario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FuncionarioID,Nombres,Apellidos,TipoIdentificacionID,Identificacion,Vigente,AreaID,GeneroID,Telefono,Celular,FechaCreacion")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AreaID = new SelectList(db.Areas, "AreaID", "NombreArea", funcionario.AreaID);
            ViewBag.GeneroID = new SelectList(db.Generos, "GeneroID", "NombreGenero", funcionario.GeneroID);
            ViewBag.TipoIdentificacionID = new SelectList(db.TipoIdentificaciones, "TipoIdentificacionID", "NombreTipo", funcionario.TipoIdentificacionID);
            return View(funcionario);
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = db.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            ViewBag.AreaID = new SelectList(db.Areas, "AreaID", "NombreArea", funcionario.AreaID);
            ViewBag.GeneroID = new SelectList(db.Generos, "GeneroID", "NombreGenero", funcionario.GeneroID);
            ViewBag.TipoIdentificacionID = new SelectList(db.TipoIdentificaciones, "TipoIdentificacionID", "NombreTipo", funcionario.TipoIdentificacionID);
            return View(funcionario);
        }

        // POST: Funcionario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FuncionarioID,Nombres,Apellidos,TipoIdentificacionID,Identificacion,Vigente,AreaID,GeneroID,Telefono,Celular,FechaCreacion")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcionario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AreaID = new SelectList(db.Areas, "AreaID", "NombreArea", funcionario.AreaID);
            ViewBag.GeneroID = new SelectList(db.Generos, "GeneroID", "NombreGenero", funcionario.GeneroID);
            ViewBag.TipoIdentificacionID = new SelectList(db.TipoIdentificaciones, "TipoIdentificacionID", "NombreTipo", funcionario.TipoIdentificacionID);
            return View(funcionario);
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = db.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        // POST: Funcionario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Funcionario funcionario = db.Funcionarios.Find(id);
            db.Funcionarios.Remove(funcionario);
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
