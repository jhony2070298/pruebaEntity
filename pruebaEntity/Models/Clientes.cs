using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pruebaEntity.Models
{
    public class Clientes
    {        
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = " Solo se aceptan letras")]   
        //[RegularExpression("^[0-9]+$", ErrorMessage = " Solo se aceptan números")]   
        public string Nombre { get; set; }
        [Required]
        [EmailAddress]
        
        public string Email { get; set; }
                  
        public List<ListaUsuarios>listaUsuarios { get; set; }
    }
}