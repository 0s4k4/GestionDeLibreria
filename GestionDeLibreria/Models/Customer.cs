using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GestionDeLibreria.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required, Display(Name ="Direccion")]
        public string Address { get; set; }

        [Required,Display(Name ="Contacto")]
        public string Contact { get; set; }
        

        
    }
}