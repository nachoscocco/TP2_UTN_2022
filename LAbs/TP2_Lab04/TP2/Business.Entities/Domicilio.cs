using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Domicilio
    {
        public int IdDomicilio { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string LetraBis { get; set; }
        public int Piso { get; set; }
        public char Depto { get; set; }
        public string Pais_s { get; set; }
        public string Provincia_s { get; set; }
        public string Localidad_s { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
    }
}
