using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using System.Data;

namespace Entidades
{
    public class eAreas : DataWorker
    {
        public int IdPadre { get; set; }
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Siglas { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }
        public string Ruta { get; set; }
        public string Ruta_Texto { get; set; }
        public string Estado { get; set; }

        public List<eAreas> Todas(int pId)
        {
            List<eAreas> lst = new List<eAreas>();

            using (IDbConnection connection = database.CreateOpenConnection())
            {
                using (IDbCommand command = database.CreateStoredProcCommand("lstAreas", connection))
                {
                    command.Parameters.Add(database.CreateParameter("@pId", pId));
                    using (IDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            eAreas a = new eAreas();
                            a.IdPadre = int.Parse(dr["ID_PADRE"].ToString());
                            a.Id = int.Parse(dr["ID"].ToString());
                            a.Clave = dr["CLAVE"].ToString();
                            a.Siglas = dr["SIGLAS"].ToString();
                            a.Descripcion = dr["DESCRIPCION"].ToString();
                            a.Nivel = int.Parse(dr["NIVEL"].ToString());
                            a.Ruta = dr["RUTA"].ToString();
                            a.Ruta_Texto = dr["RUTA_TEXTO"].ToString();

                            lst.Add(a);
                        }
                    }
                }
            }

            return lst;
        }

        public List<eAreas> xClave(int pId)
        {
            List<eAreas> lst = new List<eAreas>();

            using (IDbConnection connection = database.CreateOpenConnection())
            {
                using (IDbCommand command = database.CreateStoredProcCommand("xClaveArea", connection))
                {
                    command.Parameters.Add(database.CreateParameter("@pId", pId));
                    using (IDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            eAreas a = new eAreas();
                            a.IdPadre = int.Parse(dr["ID_PADRE"].ToString());
                            a.Id = int.Parse(dr["ID"].ToString());
                            a.Clave = dr["CLAVE"].ToString();
                            a.Siglas = dr["SIGLAS"].ToString();
                            a.Descripcion = dr["DESCRIPCION"].ToString();
                            a.Nivel = int.Parse(dr["NIVEL"].ToString());
                            a.Ruta = dr["RUTA"].ToString();
                            a.Ruta_Texto = dr["RUTA_TEXTO"].ToString();

                            lst.Add(a);
                        }
                    }
                }
            }

            return lst;
        }

        public void Nueva(eAreas area)
        {
            using (IDbConnection connection = database.CreateOpenConnection())
            {
                using (IDbCommand command = database.CreateStoredProcCommand("insArea", connection))
                {
                    command.Parameters.Add(database.CreateParameter("@pIdPadre", area.IdPadre));
                    command.Parameters.Add(database.CreateParameter("@pClave", area.Clave));
                    command.Parameters.Add(database.CreateParameter("@pSiglas", area.Siglas));
                    command.Parameters.Add(database.CreateParameter("@pDescripcion", area.Descripcion));
                    command.Parameters.Add(database.CreateParameter("@pNivel", area.Nivel));
                    command.Parameters.Add(database.CreateParameter("@pRuta", area.Ruta));
                    command.Parameters.Add(database.CreateParameter("@pRuta_Texto", area.Ruta_Texto));

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
