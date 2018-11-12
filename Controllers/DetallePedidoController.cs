using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab12.Models;
using Lab12.Repository;

namespace Lab12.Controllers
{
    public class DetallePedidoController : Controller
    {
        // GET: DetallePedido
        public ActionResult Index()
        {
            //Listar todos los pedidos
            EmpleadoRepository repository = new EmpleadoRepository();
            ModelState.Clear();

            ViewBag.IdPedido = new SelectList(repository.getPedidos(), "IdPedido", "IdPedido");


            return View(repository.getDetallePedidos());
        }

        public ActionResult IndexBusqueda(string IdPedido)
        {
            EmpleadoRepository repository = new EmpleadoRepository();
            var detPedido = repository.getDetallePedidos();

            IQueryable<DetallePedido> detallePedidos = detPedido.AsQueryable();

            if (!string.IsNullOrEmpty(IdPedido))
            {
                detallePedidos = detallePedidos.Where(p => p.IdPedido.ToString().Contains(IdPedido));
            }
            ViewBag.IdPedido = new SelectList(repository.getPedidos(), "IdPedido", "IdPedido");
            return View("Index", detallePedidos.ToList());

        }
    }
}