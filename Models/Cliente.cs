using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab12.Models
{
    public class Cliente
    {
        [Key]
        [Display(Name ="Numero de Orden")]
        public string IdCliente { get; set; }
        [Display(Name = "Nombre de compañia")]
        public string NombreCompañia { get; set; }
        [Display(Name = "cargo de Contacto")]
        public string CargoContacto { get; set; }
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        [Display(Name = "Region")]
        public string Region { get; set; }
        [Display(Name = "Código Postal")]
        public string CodPostal { get; set; }
        [Display(Name = "Pais")]
        public string Pais { get; set; }
        [Display(Name = "Número de telefono")]
        public string Telefono { get; set; }
        [Display(Name = "Fax")]
        public string Fax { get; set; }
        [Display(Name = "Estado")]
        public Boolean estado { get; set; }
    }
}