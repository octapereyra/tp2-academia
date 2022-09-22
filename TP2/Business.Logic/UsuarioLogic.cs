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
        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }
        UsuarioAdapter _UsuarioData;

        public UsuarioAdapter UsuarioData { get => _UsuarioData; set => _UsuarioData = value; }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }
        public List<Usuario> GetAll()
        {
           return UsuarioData.GetAll();
        }
        public int Save(Usuario user)
        {
            return UsuarioData.Save(user);
        }
        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }
    }
}
