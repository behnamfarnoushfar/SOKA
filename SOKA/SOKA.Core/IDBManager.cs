using System.Threading.Tasks;

namespace SOKA.Core
{
    public interface IDBManager
    {
        string ConnectionString { get; set; }
        string HostAddress { get; set; }
        int Port { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        Task<T> Execute<T>(string Query);
    }
}
