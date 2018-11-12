using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab12.Models
{
    public class Producto
    {
        [Key]
        [Display(Name = "Numero de orden")]
        public int IdProducto { get; set; }

        [Display(Name = "Nombre de Producto")]
        public string NombreProducto { get; set; }

        [Display(Name = "Codigo de Proveedor")]
        public int IdProveedor { get; set; }

        [Display(Name = "Codigo de Categoria")]
        public int IdCategoria { get; set; }

        [Display(Name = "Cantidad por Unidad")]
        public int CantidadPorUnidad { get; set; }

        [Display(Name = "Precio por Unidad")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public int PrecioUnidad { get; set; }

        [Display(Name = "Unidades en existencia")]
        public int UnidadesEnExistencia { get; set; }

        [Display(Name = "Unidades en Pedido")]
        public int UnidadesEnPedido { get; set; }

        [Display(Name = "Nivel de nuevo Pedido")]
        public int NivelNuevoPedido { get; set; }

        [Display(Name = "Suspendido")]
        public Boolean Suspendido { get; set; }
    }
}