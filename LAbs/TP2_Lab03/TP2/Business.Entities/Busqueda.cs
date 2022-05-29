using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Busqueda
    {
        public int NroBusqueda { get; set; }
        public bool Tipo { get; set; } // Fulltime o parttime
        public string nombre { get; set; }
        public string DetalleAmpliado { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
    }
}
