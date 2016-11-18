using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccesoDatos;
using Entidades;

namespace Servicios
{
    public class Areas:IAreas
    {
        public List<eAreas> Todas(int pId)
        {
            eAreas a = new eAreas();

            return a.Todas(pId);
        }

        public void Nuevo(eAreas area)
        {
            eAreas a = new eAreas();

            a.Nueva(area);
        }

        public List<eAreas> xClave(int clave)
        {
            eAreas a = new eAreas();

            return a.xClave(clave);
        }

        public void Eliminar(int clave)
        {
            throw new NotImplementedException();
        }
    }
}
