using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class conexion
    {
        public static bd Datos;
        public static bool IniciarSesion(string nombreServidor, string baseDatos, string usuario, string password)
        {
            Datos = new bdSQL(nombreServidor, baseDatos, usuario, password);
            return Datos.Autenticar();
        } //fin inicializa sesion

        public static void FinalizarSesion()
        {
            Datos.CerrarConexion();
        } //fin FinalizaSesion

    }//end class util
}
