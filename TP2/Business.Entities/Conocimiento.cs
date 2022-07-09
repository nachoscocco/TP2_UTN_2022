using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Business.Entities.BusinessEntity;


namespace Business.Entities
{
    public class Conocimiento
    {
        public int IdConocimiento { get; set; }
        public string Nombre { get; set; }
        public bool Alta { get; set; } // ¿Baja logica?

        public States State { get; set; }
    }
}
