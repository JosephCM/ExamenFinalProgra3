using Microsoft.AspNetCore.Mvc;
using SistemaGestion.Models;

namespace SistemaGestion.Controllers
{
    public class EmpleadosController : Controller
    {
        private static List<Empleado> empleados = new List<Empleado>();


        public IActionResult Index()
        {
            return View(empleados);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Empleado empleado)
        {
            Console.WriteLine($"Categoría recibida: {empleado.CategoriaLaboral}");

            if (!Enum.IsDefined(typeof(Categoria), empleado.CategoriaLaboral))
            {
                ModelState.AddModelError("CategoriaLaboral", "Categoría inválida.");
            }

            if (empleados.Any(e => e.CorreoElectronico == empleado.CorreoElectronico))
            {
                ModelState.AddModelError("CorreoElectronico", "El correo electrónico ya está registrado.");
            }

            if (ModelState.IsValid)
            {
                empleado.Id = empleados.Count + 1;
                empleados.Add(empleado);
                return RedirectToAction(nameof(Index));
            }

            return View(empleado);
        }
    }
}
