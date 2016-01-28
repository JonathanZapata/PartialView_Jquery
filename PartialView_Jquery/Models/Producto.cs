using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView_Jquery.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public DateTime FechaManufactura { get; set; }
        public double Precio { get; set; }
        public bool IsDisponible { get; set; }
    }
}