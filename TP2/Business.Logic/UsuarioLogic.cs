using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private UsuarioAdapter _usuarioData;
        public UsuarioLogic(UsuarioAdapter usuarioData)
        {
            _usuarioData = usuarioData;
        }

        public Usuario GetOne(int id)
        {
            return _usuarioData.GetOne(id);
        }

        public List<Usuario> GetAll()
        {
            return _usuarioData.GetAll();
        }

        public void Deleted(int id)
        {
            _usuarioData.Delete(id);
        }

        public void Save(Usuario usr)
        {
            _usuarioData.Save(usr);
        }
    }
}
