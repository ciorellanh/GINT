using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using Entidades;
using System.ServiceModel;

namespace Servicios
{
    [ServiceContract]
    interface IUsuarios
    {
        [OperationContract]
        void Nuevo(eUsuarios usuario);

        [OperationContract]
        List<eUsuarios> Todos();

        [OperationContract]
        eUsuarios xClave(string clave);
    }
}
