using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Lab14.Models;

namespace lab14.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        private NORTHWNDEntities _contexto;

        public NORTHWNDEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new NORTHWNDEntities();
                return _contexto;
            }
        }
        public ActionResult Index()
        {
            return View(Contexto.Categories.ToList());
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            var productosPorcategoria = from p in Contexto.Products
                                        orderby p.ProductName ascending
                                        where p.CategoryID == id
                                        select p;
            return View(productosPorcategoria.ToList());
        }

        // GET: /Categories/Create
        //mostrar formulario
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categories nuevaCategoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Categories.Add(nuevaCategoria);
                    Contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(nuevaCategoria);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Categories categoriaEditar = Contexto.Categories.Find(id);

            if (categoriaEditar == null)
                return HttpNotFound();

            return View(categoriaEditar);
        }

        [HttpPost]
        public ActionResult Edit(Categories CategoriaEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Entry(CategoriaEditar).State = System.Data.Entity.EntityState.Modified;
                    Contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(CategoriaEditar);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Categories categoriaEliminar = Contexto.Categories.Find(id);

            if (categoriaEliminar == null)
                return HttpNotFound();

            Contexto.Categories.Remove(categoriaEliminar);
            Contexto.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int? id, Categories Categoria1)
        {
            try
            {
                Categories categoriaEliminar = new Categories();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    categoriaEliminar = Contexto.Categories.Find(id);

                    if (categoriaEliminar == null)
                        return HttpNotFound();

                    Contexto.Categories.Remove(categoriaEliminar);
                    Contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(categoriaEliminar);
            }
            catch
            {
                return View();
            }
        }


    }
}