using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
using Data.Database.Adapters;

namespace Business.Logic
{
    public class ConocimientoLogic : BusinessLogic
    {
        private ConocimientoAdapter _conocimientoData;
        public ConocimientoAdapter ConocimientoData
        {
            get { return _conocimientoData; }
            set { _conocimientoData = value; }
        }
        public ConocimientoLogic()
        {
            ConocimientoData = new ConocimientoAdapter();
        }

        public Conocimiento GetOne(int id)
        {
            return ConocimientoData.GetOneId(id);
        }

        public List<Conocimiento> GetAll()
        {
            return ConocimientoData.GetAll();
        }

        public void Deleted(int id)
        {
            ConocimientoData.Delete(id);
        }

        public void Save(Conocimiento cno)
        {
            ConocimientoData.Save(cno);
        }
    }
}
