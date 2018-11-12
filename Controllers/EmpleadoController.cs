using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab12.Models;
using Lab12.Repository;

namespace Lab12.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            EmpleadoRepository repository = new EmpleadoRepository();
            ModelState.Clear();
            return View(repository.getEmployees());
        }

        public ActionResult IndexBusqueda(string nombre)
        {
            EmpleadoRepository repository = new EmpleadoRepository();
            var emp = repository.getEmployees();

            IQueryable<Empleado> empleado = emp.AsQueryable();

            if (!string.IsNullOrEmpty(nombre))
            {
                empleado = empleado.Where(p => p.Nombre.Contains(nombre));
            }
            return View("Index", empleado.ToList());
            
        }
    }
}