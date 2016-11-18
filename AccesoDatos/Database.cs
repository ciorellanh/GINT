using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AccesoDatos
{
    public abstract class Database
    {
        public string connectionString;

        #region Abstract Functions
        public abstract IDbConnection CreateConnection();
        public abstract IDbCommand CreateCommand();
        public abstract IDbConnection CreateOpenConnection();
        public abstract IDbCommand CreateCommand(string commandText, IDbConnection connection);
        public abstract IDbCommand CreateStoredProcCommand(string procName, IDbConnection connection);
        public abstract IDbCommand CreateStoredProcCommand(string procName, IDbConnection connection, params Object[] args);
        public abstract IDataParameter CreateParameter(string parameterName, object parameterValue);
        protected abstract void CargarParametros(System.Data.IDbCommand com, Object[] args);
        #endregion
    }
}
