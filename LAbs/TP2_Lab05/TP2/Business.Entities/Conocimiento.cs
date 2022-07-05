using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Conocimiento
    {
        public int IdConocimiento { get; set; }
        public int Nombre { get; set; }
        public bool Alta { get; set; } // ¿Baja logica?
    }
}
