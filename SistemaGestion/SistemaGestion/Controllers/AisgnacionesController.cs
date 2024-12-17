using Microsoft.AspNetCore.Mvc;
using SistemaGestion.Models;

namespace SistemaGestion.Controllers
{
    public class AsignacionesController : Controller
    {
        private static List<Asignacion> asignaciones = new List<Asignacion>();
        private static List<Empleado> empleados = new List<Empleado>();
        private static List<Proyecto> proyectos = new List<Proyecto>();

        public IActionResult Index()
        {
            return View(asignaciones);
        }

        public IActionResult Create()
        {
            ViewBag.Empleados = empleados;
            ViewBag.Proyectos = proyectos;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Asignacion asignacion)
        {
            if (ModelState.IsValid)
            {
                asignacion.Id = asignaciones.Count + 1;
                asignaciones.Add(asignacion);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Empleados = empleados;
            ViewBag.Proyectos = proyectos;
            return View(asignacion);
        }
    }
}