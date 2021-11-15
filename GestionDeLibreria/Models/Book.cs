using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GestionDeLibreria.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [Display(Name ="Titulo")]
        public string Title { get; set; }

        [Required]
        [Display(Name ="Numero serial")]
        public string SerialNumber { get; set; }
        [Display(Name ="Autor")]
        public string Author { get; set; }

        [Display(Name ="Publicador")]
        public string Publisher { get; set; }

    }
}