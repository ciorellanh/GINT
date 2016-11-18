using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Entidades;
using AccesoDatos;

namespace Servicios
{
    [ServiceContract]
    interface IAreas
    {
        [OperationContract]
        void Nuevo(eAreas area);

        [OperationContract]
        List<eAreas> Todas(int pId);

        [OperationContract]
        List<eAreas> xClave(int clave);

        [OperationContract]
        void Eliminar(int clave);
    }
}
