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
        public void Nuevo(eUsuarios usuario)
        {
            conexion.Datos.Ejecutar("insCliente", usuario.Cuenta, usuario.Clave, usuario.Nombre, usuario.IdArea, usuario.Telefono, usuario.Estado);
        }

        public List<eUsuarios> Todos()
        {
            conexion.IniciarSesion("localhost", "GINT", "sa", "Calidad");
            IDataReader dr =conexion.Datos.TraerDataReader("cstUsuarios");
            List<eUsuarios> lst = new List<eUsuarios>();

            while (dr.Read())
            {
                eUsuarios usu = new eUsuarios();
                usu.Cuenta = dr["CUENTA"].ToString();
                usu.Clave = dr["CLAVE"].ToString();
                usu.Nombre = dr["NOMBRE"].ToString();
                usu.IdArea = int.Parse(dr["ID_AREA"].ToString());
                usu.Telefono = dr["TELEFONO"].ToString();

                lst.Add(usu);
            }


            return lst;
        }

        public eUsuarios xClave(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
