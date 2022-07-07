using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Especialidad
    {
        public int IdEspecialidad { get; set; }
        public int NombreEspecialidad { get; set; }
        public bool Alta { get; set; } // ¿Baja logica?
        
        //1 - Electrica,
        //2 - Sistemas,
        //3 - Mecanica,
        //4 - Quimica,
        //5 - Civil
    }
    //public enum Especialidad
}