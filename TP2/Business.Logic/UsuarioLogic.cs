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
        UsuarioAdapter _usuarioData;

        public UsuarioAdapter UsuarioData { get => _usuarioData; set => _usuarioData = value; }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }
        public List<Usuario> GetAll()
        {
           return UsuarioData.GetAll();
        }
        public void Save(Usuario user)
        {
            UsuarioData.Save(user);
        }
        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }
    }
}
