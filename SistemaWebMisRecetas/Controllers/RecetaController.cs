using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly RecetaContext context;

        public RecetaController(RecetaContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var recetas = context.Recetas.ToList();
            return View(recetas);
        }

        [HttpGet]
        public ActionResult Filter(string text)
        {
            var recetas = (from r in context.Recetas
                           where text == r.NombreAutor || text == r.ApellidoAutor
                           select r).ToList();

            return View("Index", recetas);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var receta = new Receta();
            return View("Create", receta);
        }

        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(receta);
        }

        [HttpGet]
        public ActionResult Details(string title)
        {
            var receta = (from i in context.Recetas
                          where title == i.Titulo
                          select i).FirstOrDefault();

            if (receta == null)
                return NotFound();
            else
                return View("Details", receta);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var receta = ObtenerUno(id);

            if (receta == null)
                return NotFound();

            return View("Delete", receta);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var receta = ObtenerUno(id);
            if (receta == null)
                return NotFound();
            else
            {
                context.Recetas.Remove(receta);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var receta = ObtenerUno(id);
            return View(nameof(Edit), receta);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Entry(receta).State = EntityState.Modified;
                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(nameof(Edit));            
        }

        private Receta ObtenerUno(int id)
        {
            return context.Recetas.Find(id);
        }
    }
}
