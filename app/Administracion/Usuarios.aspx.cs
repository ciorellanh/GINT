using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using sUsuarios;
using System.Web.Services;

public partial class Administracion_Usuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    [WebMethod]
    public static List<eUsuarios> Consultar_Todos()
    {
        UsuariosClient usu = new UsuariosClient();

        return usu.Todos().ToList();
    }
}