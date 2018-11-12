using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab12.Models;
using Lab12.Repository;

namespace Lab12.Controllers
{
    public class PedidoController : Controller
    {
        // GET: Pedido
        public ActionResult Index()
        {
            //Listar todos los pedidos
            EmpleadoRepository repository = new EmpleadoRepository();
            ModelState.Clear();

             ViewBag.IdCliente = new SelectList(repository.getClients(), "IdCliente", "NombreCompañia");


            return View(repository.getPedidos());
        }

        public ActionResult IndexBusqueda(string IdCliente)
        {
            EmpleadoRepository repository = new EmpleadoRepository();
            var pedido = repository.getPedidos();

            IQueryable<Pedido> pedidos = pedido.AsQueryable();

            if (!string.IsNullOrEmpty(IdCliente))
            {
                pedidos = pedidos.Where(p => p.IdCliente.Contains(IdCliente));
            }
            ViewBag.IdCliente = new SelectList(repository.getClients(), "IdCliente", "NombreCompañia");
            return View("Index", pedidos.ToList());

        }
    }
}