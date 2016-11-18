using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Servicios
{
    class Usuarios:IUsuarios
    {

        public string ValidaUsuario(string pUsuario)
        {
            eUsuarios u = new eUsuarios();

            return u.LogIn(pUsuario);
        }

        public void Nuevo(eUsuarios usuario)
        {
            throw new NotImplementedException();
        }

        public List<eUsuarios> Todos(int pUbicacion)
        {
            throw new NotImplementedException();
        }

        public List<eUsuarios> xClave(string clave)
        {
            eUsuarios u = new eUsuarios();

            return u.xClave(clave);
        }

        public void Eliminar(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
