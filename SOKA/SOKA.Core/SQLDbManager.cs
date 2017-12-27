using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SOKA.Core
{
    public class SQLDbManager : IDBManager
    {
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HostAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task<IEnumerable<T>> Execute<T>(string Query)
        {
            using (SqlConnection connection=new SqlConnection(ConnectionString))
            {
                return await connection.QueryAsync<T>(Query);
            }
        }
    }
}
