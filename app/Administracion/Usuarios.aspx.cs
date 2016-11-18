using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Services;

public partial class Administracion_Usuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    //[WebMethod]
    //public static List<eUsuarios> Consultar_Todos(int pUbicacion)
    //{
    //    UsuariosClient usu = new UsuariosClient();

    //    return usu.Todos(pUbicacion).ToList();
    //}

    //[WebMethod]
    //public static void Nuevo(string pCuenta,string pClave,string pNombre,int pArea,string pTelefono)
    //{
    //    UsuariosClient usu = new UsuariosClient();
    //    eUsuarios u=new eUsuarios();

    //    u.Clave=pClave;
    //    u.Cuenta=pCuenta;
    //    u.Nombre=pNombre;
    //    u.IdArea=pArea;
    //    u.Telefono=pTelefono;

    //    usu.Nuevo(u);
    //}

    //[WebMethod]
    //public static void Eliminar(string pCuenta)
    //{
    //    UsuariosClient usu = new UsuariosClient();

    //    usu.Eliminar(pCuenta);
    //}
}