using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TercerParcial.Models
{
    public class Puntos
    {
        [Key]
        public string nombre { get; set; }
        public string ubi { get; set; }
        public string desc { get; set; }
        public int num { get; set; }
        public string fotos { get; set; }


    }
}
