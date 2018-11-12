using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab12.Models
{
    public class Pedido
    {
        [Key]
        [Display(Name = "Numero de orden")]
        public int IdPedido { get; set; }

        [Display(Name = "Codigo de Cliente")]
        public string IdCliente { get; set; }

        [Display(Name = "Codigo de Empleado")]
        public int IdEmpleado { get; set; }

        [Display(Name = "Fecha de Pedido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaPedido { get; set; }

        [Display(Name = "Fecha de Entrega")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaEntrega { get; set; }

        [Display(Name = "Fecha de Envio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaEnvio { get; set; }

        [Display(Name = "Forma de Envio")]
        public int FormaEnvio { get; set; }

        [Display(Name = "Cargo")]
        public double Cargo { get; set; }

        [Display(Name = "Destinatario")]
        public string Destinatario { get; set; }
    }
}