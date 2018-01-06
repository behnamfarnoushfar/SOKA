using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SOKA.Core
{
    public class SQLDbManager : IDBManager
    {
        public string ConnectionString { get ; set ; }
        public string HostAddress { get ; set ; }
        public int Port { get ; set ; }
        public string UserName { get ; set ; }
        public string Password { get ; set ; }
        public SQLDbManager(string  host,int port,string db,string user,string pass)
        {
            HostAddress = host;
            UserName = user;
            Password = pass;
            Port = port;
            ConnectionString = $"Data Source={host},{port};Initial Catalog = {db}; User ID = {user}; Password = {pass}";
        }
        public async Task<IEnumerable<T>> Execute<T>(string Query)
        {
            using (SqlConnection connection=new SqlConnection(ConnectionString))
            {
                return await connection.QueryAsync<T>(Query);
            }
        }
    }
}
