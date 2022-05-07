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
        UsuarioLogic()
        {
            Data.Database.UsuarioAdapter UsuarioData = UsuarioLogic.New;
        }
    }
}
