using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using Entidades;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Servicios
{
    [ServiceContract]
    interface IUsuarios
    {
        [OperationContract]
        string ValidaUsuario(string pUsuario);

        [OperationContract]
        void Nuevo(eUsuarios usuario);

        [OperationContract]
        List<eUsuarios> Todos(int pUbicacion);

        [OperationContract]
        List<eUsuarios> xClave(string clave);

        [OperationContract]
        void Eliminar(string clave);
    }
}
