using Microsoft.AspNetCore.Mvc;
using SistemaGestion.Models;

namespace SistemaGestion.Controllers
{
    public class ProyectosController : Controller
    {
        private static List<Proyecto> proyectos = new List<Proyecto>();

        // GET: Lista de proyectos
        public IActionResult Index()
        {
            return View(proyectos);
        }

        // GET: Formulario de creación
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Proyecto proyecto)
        {
            if (proyecto.FechaFin.HasValue && proyecto.FechaFin.Value < proyecto.FechaInicio)
            {
                ModelState.AddModelError("FechaFin", "La fecha de finalización no puede ser anterior a la de inicio.");
            }

            if (ModelState.IsValid)
            {
                proyecto.Id = proyectos.Count + 1;
                proyectos.Add(proyecto);
                return RedirectToAction(nameof(Index));
            }

            return View(proyecto);
        }
    }
}