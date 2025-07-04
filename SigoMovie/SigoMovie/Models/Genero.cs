using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SigoMovie.Models
{
    public class Genero
    {
        public String GeneroId { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligaorio.")]
        public String Nombre { get; set; }
    }
}