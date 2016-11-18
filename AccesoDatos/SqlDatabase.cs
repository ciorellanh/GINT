using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    class SqlDatabase:Database
    {
        public override IDbConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }
        public override IDbCommand CreateCommand()
        {
            return new SqlCommand();
        }
        public override IDbConnection CreateOpenConnection()
        {
            SqlConnection connection = (SqlConnection)CreateConnection();
            connection.Open();
            return connection;
        }
        public override IDbCommand CreateCommand(string commandText, IDbConnection connection)
        {
            SqlCommand command = (SqlCommand)CreateCommand();
            command.CommandText = commandText;
            command.Connection = (SqlConnection)connection;
            command.CommandType = CommandType.Text;
            return command;
        }
        public override IDbCommand CreateStoredProcCommand(string procName, IDbConnection connection)
        {
            SqlCommand command = (SqlCommand)CreateCommand();
            command.CommandText = procName;
            command.Connection = (SqlConnection)connection;
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

        public override IDbCommand CreateStoredProcCommand(string procName, IDbConnection connection, params Object[] args)
        {
            SqlCommand command = (SqlCommand)CreateCommand();
            command.CommandText = procName;
            command.Connection = (SqlConnection)connection;
            command.CommandType = CommandType.StoredProcedure;
            CargarParametros(command, args);
            return command;
        }

        public override IDataParameter CreateParameter(string parameterName, object parameterValue)
        {
            return new SqlParameter(parameterName, parameterValue);
        }

        protected override void CargarParametros(System.Data.IDbCommand com, Object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                com.Parameters.Insert(i, args[i]);
            }
            //for (int i = 1; i < com.Parameters.Count; i++)
            //{
            //    var p = (System.Data.SqlClient.SqlParameter)com.Parameters[i];
            //    p.Value = i <= args.Length ? args[i - 1] ?? DBNull.Value : null;
            //}
        }
    }
}
