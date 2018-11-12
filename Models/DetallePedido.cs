using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab12.Models
{
    public class DetallePedido
    {
        [Key]
        [Display(Name = "Numero de pedido")]
        public int IdPedido { get; set; }
        [Display(Name = "Identificador de producto")]
        public int IdProducto { get; set; }
        [Display(Name = "Nombre de producto")]
        public string NombreProducto { get; set; }
        [Display(Name = "Precio")]
        public double PrecioUnidad { get; set; }
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
    }
}