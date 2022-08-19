using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Business.Entities.BusinessEntity;

namespace Business.Entities
{
    public class Domicilio
    {
        public int IdDomicilio { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public bool EsBis { get; set; }
        public int Piso { get; set; }
        public char Depto { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public States State { get; set; }
    }
}
