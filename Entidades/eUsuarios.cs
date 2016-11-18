using System.Collections.Generic;
using AccesoDatos;
using System.Data;

namespace Entidades
{
    public class eUsuarios:DataWorker
    {
        public string Cuenta { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }

        public int IdArea { get; set; }
        public string Area{get;set;}

        public string Telefono { get; set; }
        public string Estado { get; set; }

        public int IdPerfil { get; set; }
        public string Perfil { get; set; }

        public string LogIn(string pClave)
        {
            int filas=0;
            string VALIDA = "NO";

            using (IDbConnection connection = database.CreateOpenConnection())
            {
                using (IDbCommand command = database.CreateStoredProcCommand("xClaveUsuario", connection))
                {
                    command.Parameters.Add(database.CreateParameter("@pClave", pClave));
                    using (IDataReader dr = command.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            filas++;

                            if(filas>0){
                                VALIDA="VALIDADO";
                            }
                        }
                    }
                }
            }
            return VALIDA;
        }

        public List<eUsuarios> xClave(string pId)
        {
            List<eUsuarios> lst = new List<eUsuarios>();

            using (IDbConnection connection = database.CreateOpenConnection())
            {
                using (IDbCommand command = database.CreateStoredProcCommand("xClaveUsuario", connection))
                {
                    command.Parameters.Add(database.CreateParameter("@pClave", pId));
                    using (IDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            eUsuarios u = new eUsuarios();
                            u.Cuenta = dr["CUENTA"].ToString();
                            u.Clave = dr["CLAVE"].ToString();
                            u.Nombre = dr["NOMBRE"].ToString();
                            u.IdArea = int.Parse(dr["ID_AREA"].ToString());
                            u.Telefono = dr["TELEFONO"].ToString();
                            u.IdPerfil = int.Parse(dr["ID_ROL"].ToString());
                            u.Estado = dr["ESTADO"].ToString();

                            lst.Add(u);
                        }
                    }
                }
            }

            return lst;
        }
    }
}
