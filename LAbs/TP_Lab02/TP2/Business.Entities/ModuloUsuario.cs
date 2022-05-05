using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        private int _idUsuario;
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private int _idModulo;
        public int IdModulo
        {
            get { return _idModulo; }
            set { _idModulo = value; }
        }

        private bool _permiteAlta;
        public bool PermiteAlta
        {
            get { return _permiteAlta; }
            set { _permiteAlta = value; }
        }

        private bool _permiteBaja;
        public bool PermiteBaja
        {
            get { return _permiteBaja; }
            set { _permiteBaja = value; }
        }

        private bool _permiteModificacion;
        public bool PermiteModificacion
        {
            get { return _permiteModificacion; }
            set { _permiteModificacion = value; }
        }

        private bool _permiteConsulta;
        public bool PermiteConsulta
        {
            get { return _permiteConsulta; }
            set { _permiteConsulta = value; }
        }
    }
}
