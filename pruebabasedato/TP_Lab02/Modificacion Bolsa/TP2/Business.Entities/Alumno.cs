using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Entities
{
    class Alumno : Usuario
    {
        public int LegajoAlumno { get; set; }
        public int Cuil { get; set; }
        public string Sexo { get; set; }
        public string TipoDoc { get; set; }
        public int NumeroDoc { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }

        public Especialidad Espec { get; set; }
        public int MateriasAprobadas { get; set; }
        public int Plan { get; set; }
        public int AnioActual { get; set; }
        public double PromedioNoAplazo { get; set; }
        public double PromedioAplazo { get; set; }
        public string TituloSecundario { get; set; }
        public string CV { get; set; }
        public string Observaciones { get; set; }

    }
}
