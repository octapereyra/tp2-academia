using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class LoginLogic
    {
        public Usuario GetUsuario(String username, String pass) 
        {
            UsuarioLogic ul = new();
            List<Usuario> users = ul.GetAll();
            Usuario userLogged = null;

            foreach (Usuario user in users)
            {
                if (user.NombreUsuario.Equals(username) && user.Clave.Equals(pass))
                {
                    userLogged = user;
                }
            }
            return userLogged;
        }
    }
}
