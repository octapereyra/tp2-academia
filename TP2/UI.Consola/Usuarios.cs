using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        public Usuarios()
        {
            UsuarioNegocio = new UsuarioLogic();
        }

        UsuarioLogic _usuarioNegocio;

        public UsuarioLogic UsuarioNegocio { get => _usuarioNegocio; set => _usuarioNegocio = value; }

        public void Menu()
        {
            ConsoleKeyInfo consoleKey;

            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1- Listado general");
                Console.WriteLine("2- Consulta");
                Console.WriteLine("3- Agregar");
                Console.WriteLine("4- Modificar");
                Console.WriteLine("5- Eliminar");
                Console.WriteLine("6- Salir");

                consoleKey = Console.ReadKey();

                switch (consoleKey.Key)
                {
                    case ConsoleKey.D1:
                        ListadoGeneral();
                        break;
                    case ConsoleKey.D2:
                        Consultar();
                        break;
                    case ConsoleKey.D3:
                        Agregar();                
                        break;
                    case ConsoleKey.D4:
                        Modificar();
                        break;
                    case ConsoleKey.D5:
                        Eliminar();
                        break;
                    default:
                        break;
                }
            }
            while (consoleKey.Key != ConsoleKey.D6);
        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario user in UsuarioNegocio.GetAll())
            {
                MostrarDatos(user);
            }
        }

        public void MostrarDatos(Usuario user)
        {
            Console.WriteLine("Usuario: " + user.ID);
            Console.WriteLine("\t\tNombre: "+user.Nombre);
            Console.WriteLine("\t\tApellido: " + user.Apellido);
            Console.WriteLine("\t\tNombre de usuario: " + user.NombreUsuario);
            Console.WriteLine("\t\tClave: " + user.Clave);
            Console.WriteLine("\t\tEmail: " + user.EMail);
            Console.WriteLine("\t\tHabilitado: " + user.Habilitado);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a consultar: ");
                int id = int.Parse(Console.ReadLine());
                MostrarDatos(UsuarioNegocio.GetOne(id));
            }
            catch (FormatException)
            {
                Console.WriteLine("La ID ingresada debe ser un número entero");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Modificar()
        {
            try
            {
                Console.WriteLine("Ingrese ID  del usuario a modificar");
                int ID = int.Parse(Console.ReadLine());
                Usuario usu = UsuarioNegocio.GetOne(ID);
                Console.WriteLine("Ingrese nombre");
                usu.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido");
                usu.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese nombre de usuario");
                usu.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese clave");
                usu.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese Email");
                usu.EMail = Console.ReadLine();
                Console.WriteLine("Ingrese habilitacion de usuario 1-Si /2-No");
                usu.Habilitado = (Console.ReadLine() == "1");
                usu.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usu);
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada  debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Pulse una tecla para continuar");
                Console.ReadKey();
            }
        }
        public void Agregar()
        {
            Usuario usu = new Usuario();
            Console.WriteLine("Ingrese nombre");
            usu.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido");
            usu.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese nombre de usuario");
            usu.NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese clave");
            usu.Clave = Console.ReadLine();
            Console.WriteLine("Ingrese Email");
            usu.EMail = Console.ReadLine();
            Console.WriteLine("Ingrese habilitacion de usuario 1-Si /2-No");
            usu.Habilitado = (Console.ReadLine() == "1");
            usu.State = Business.Entities.BusinessEntity.States.New;
            UsuarioNegocio.Save(usu);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", usu.ID);
        }
        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese ID del usuario a eliminar");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada  debe ser un valor entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Pulse una tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
