using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SigoMovie.Models.Entitys
{
    public class Pelicula
    {
        public String PeliculaId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public String Titulo { get; set; }

        public int Dutacion { get; set; }

        [DataType(DataType.MultilineText)]
        public String Descripcion { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime FechaEstreno { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime FechaCreacion { get; set; }

        public Genero Genero { get; set; }
    }
}