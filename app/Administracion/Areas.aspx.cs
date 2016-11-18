using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using sAreas;
using sUsuarios;
using System.Web.Services;

public partial class Administracion_Areas : System.Web.UI.Page
{
    public static string usuario = "97012164";
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    [WebMethod]
    public static List<eAreas> Consultar_Todas(int pUbicacion)
    {
        AreasClient a = new AreasClient();

        return a.Todas(pUbicacion).ToList();
    }

    [WebMethod]
    public static List<eAreas> Consultar_xClave(int pClave)
    {
        AreasClient a = new AreasClient();

        return a.xClave(pClave).ToList();
    }

    [WebMethod]
    public static void NuevaArea(int pPadre,string pClave,string pSiglas,string pDescripcion,string pRuta,string pRuta_Texto)
    {
        AreasClient a = new AreasClient();
        eAreas nueva = new eAreas();

        nueva.IdPadre = pPadre;
        nueva.Clave = pClave;
        nueva.Siglas = pSiglas;
        nueva.Descripcion = pDescripcion;
        nueva.Ruta = pRuta;
        nueva.Ruta_Texto = pRuta_Texto;

        a.Nuevo(nueva);
    }

    [WebMethod]
    public static List<eUsuarios> UsuarioActivo()
    {
        UsuariosClient u = new UsuariosClient();

        

        return u.xClave(usuario).ToList();
    }
}