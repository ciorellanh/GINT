using System;

namespace AccesoDatos
{
    public class bdSQL:bd
    {
        static readonly System.Collections.Hashtable ColComandos = new System.Collections.Hashtable();

        public override sealed string CadenaConexion
        {
            get
	        {
		        return System.Configuration.ConfigurationManager.ConnectionStrings["local"].ConnectionString;
	        }// end get
            set
            { MCadenaConexion = value; } // end set
        }// end CadenaConexion

        protected override void CargarParametros(System.Data.IDbCommand com, Object[] args)
        {
            for (int i = 1; i < com.Parameters.Count; i++)
            {
                var p = (System.Data.SqlClient.SqlParameter)com.Parameters[i];
                p.Value = i <= args.Length ? args[i - 1] ?? DBNull.Value : null;
            }
        }

        protected override System.Data.IDbCommand Comando(string procedimientoAlmacenado)
        {
            System.Data.SqlClient.SqlCommand com;
            if (ColComandos.Contains(procedimientoAlmacenado))
                com = (System.Data.SqlClient.SqlCommand)ColComandos[procedimientoAlmacenado];
            else
            {
                var con2 = new System.Data.SqlClient.SqlConnection(CadenaConexion);
                con2.Open();
                com = new System.Data.SqlClient.SqlCommand(procedimientoAlmacenado, con2) { CommandType = System.Data.CommandType.StoredProcedure };
                System.Data.SqlClient.SqlCommandBuilder.DeriveParameters(com);
                con2.Close();
                con2.Dispose();
                ColComandos.Add(procedimientoAlmacenado, com);
            }//end else
            com.Connection = (System.Data.SqlClient.SqlConnection)Conexion;
            com.Transaction = (System.Data.SqlClient.SqlTransaction)MTransaccion;
            return com;
        }// end Comando

        protected override System.Data.IDbCommand ComandoSql(string comandoSql)
        {
            var com = new System.Data.SqlClient.SqlCommand(comandoSql, (System.Data.SqlClient.SqlConnection)Conexion, (System.Data.SqlClient.SqlTransaction)MTransaccion);
            return com;
        }// end Comando

        protected override System.Data.IDbConnection CrearConexion(string cadenaConexion)
        { return new System.Data.SqlClient.SqlConnection(cadenaConexion); }

        protected override System.Data.IDataAdapter CrearDataAdapter(string procedimientoAlmacenado, params Object[] args)
        {
            var da = new System.Data.SqlClient.SqlDataAdapter((System.Data.SqlClient.SqlCommand)Comando(procedimientoAlmacenado));
            if (args.Length != 0)
                CargarParametros(da.SelectCommand, args);
            return da;
        } // end CrearDataAdapter

        protected override System.Data.IDataAdapter CrearDataAdapterSql(string comandoSql)
        {
            var da = new System.Data.SqlClient.SqlDataAdapter((System.Data.SqlClient.SqlCommand)ComandoSql(comandoSql));
            return da;
        } // end CrearDataAdapterSql

        public bdSQL()
        {
	        Base = "";
	        Servidor = "";
	        Usuario = "";
	        Password = "";
        }// end DatosSQLServer
 
        public bdSQL(string cadenaConexion)
        { CadenaConexion = cadenaConexion; }// end DatosSQLServer
 
        public bdSQL(string servidor, string @base)
        {
	        Base = @base;
	        Servidor = servidor;
        }// end DatosSQLServer

        public bdSQL(string servidor, string @base, string usuario, string password)
        {
	        Base = @base;
	        Servidor = servidor;
	        Usuario = usuario;
	        Password = password;
        }// end DatosSQLServer
    }
}
