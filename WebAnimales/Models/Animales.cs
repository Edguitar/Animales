using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAnimales.Models
{
    public class Animales
    {
        public int AnimalesID { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Propietario { get; set; }
    }
}