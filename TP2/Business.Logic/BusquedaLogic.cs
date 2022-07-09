using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class BusquedaLogic : BusinessLogic
    {
        public BusquedaAdapter BusquedaAdapter { get; set; }
        public BusquedaLogic()
        {
            BusquedaAdapter = new BusquedaAdapter();
        }

        public Busqueda GetOneById(int id)
        {
            return BusquedaAdapter.GetOneById(id);
        }

        public List<Busqueda> GetAll()
        {
            return BusquedaAdapter.GetAll();
        }

        public void Deleted(int id)
        {
            BusquedaAdapter.Delete(id);
        }

        public void Save(Busqueda usr)
        {
            BusquedaAdapter.Save(usr);
        }
    }
}
