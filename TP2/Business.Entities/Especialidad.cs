using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Business.Entities.BusinessEntity;

namespace Business.Entities
{
    public class Especialidad
    {
        public int IdEspecialidad { get; set; }
        public string NombreEspecialidad { get; set; }
        public bool Alta { get; set; } // ¿Baja logica?
        public States State { get; set; }

        //1 - Electrica,
        //2 - Sistemas,
        //3 - Mecanica,
        //4 - Quimica,
        //5 - Civil
    }
    //public enum Especialidad
}