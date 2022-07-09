using System;
using static Business.Entities.BusinessEntity;


namespace Business.Entities
{
    public class Busqueda
    {
        public int NroBusqueda { get; set; }
        public bool Tipo { get; set; } 
        public string Nombre { get; set; }
        public string DetalleAmpliado { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public bool Habilitado { get; set; }

        public States State { get; set; }
    }
}
