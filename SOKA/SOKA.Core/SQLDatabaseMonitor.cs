using SOKA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SOKA.Core
{
    public class SQLDatabaseMonitor : IDatabaseMonitor
    {
        public IDBManager Database { get; set; }
        public int QueryTimeThreshold { get; set; }
        public int QueryCountThreshold { get; set; }
        public int LockTimeThreshold { get; set; }
        public int LockCountThreshold { get; set; }
        public int CPUUsageThreshold { get; set; }
        public int RAMUsageThreashold { get; set; }
        public int IOUsageThreshold { get; set; }
        public int StorageUsageThreashold { get; set; }
        public int InstanceCheckStatusInterval { get; set; }
        public int IndexCheckStatusInterval { get; set; }
        public int ReplicationStatusCheckInterval { get; set; }
        public List<string> IndexCheckNames { get; set; }
        public List<RunningQueryModel> LastQueries { get; set; }
        public List<dynamic> LastLocks { get; set; }
        public List<dynamic> LastMetrics { get; set; }
        public List<dynamic> LastIndexStatuses { get; set; }
        public List<dynamic> LastReplicationStats { get; set; }
        public DateTime LastRun { get; set; }

        public event EventHandler<dynamic> OnInstanceConnected;
        public event EventHandler<dynamic> OnInstanceDisConnected;
        public event EventHandler<dynamic> OnQueryCountThresholdExceeded;
        public event EventHandler<dynamic> OnQueryTimeThresholdExceeded;
        public event EventHandler<dynamic> OnLockCountExceeded;
        public event EventHandler<dynamic> OnLockTimeExceeded;
        public event EventHandler<dynamic> OnStorageExceeded;
        public event EventHandler<dynamic> OnCPUExceeded;
        public event EventHandler<dynamic> OnRAMExceeded;
        public event EventHandler<dynamic> OnIOExceeded;
        public event EventHandler<dynamic> OnSensetiveDataDetected;
        public event EventHandler<dynamic> OnAlterOccured;

        public async Task DoMonitoring()
        {
            await Task.Factory.StartNew(async () =>
             {
                 while (true)
                 {
                     var result = await GetRunningQueriesAsync();
                     OnInstanceConnected(this, null);
                     if (result.Count > QueryCountThreshold)
                         OnQueryCountThresholdExceeded(this, new { QueriesCount = result.Count });
                     if (result.Count(x => x.TotalTime > QueryTimeThreshold) > 0)
                         OnQueryTimeThresholdExceeded(this, new { AvgExceededtime = result.Where(x => x.TotalTime > QueryTimeThreshold).Average(x=>x.TotalTime) });
                     Thread.Sleep(InstanceCheckStatusInterval);
                 }
             });
        }

        public Task<List<dynamic>> GetCurrentMetrics()
        {
            throw new NotImplementedException();
        }

        public Task<List<dynamic>> GetIndexStatuses()
        {
            throw new NotImplementedException();
        }

        public Task<List<dynamic>> GetReplicationStatuses()
        {
            throw new NotImplementedException();
        }

        public Task<List<dynamic>> GetRunningLocks()
        {
            throw new NotImplementedException();
        }

        public async Task<List<RunningQueryModel>> GetRunningQueriesAsync()
        {
            var result = await Database.Execute<RunningQueryModel>("select   r.session_id  SessionId,   r.percent_complete PercentComplete,   s.login_name LoginName,   c.client_net_address IP,   s.host_name HostName,   db_name(dbid) as DbName,   st.text QueryText,   r.status Status,   r.command Command,   (SELECT SUM( granted_memory_kb/1024) FROM  sys.dm_exec_query_memory_grants  WHERE sys.dm_exec_query_memory_grants.sql_handle=r.sql_handle ) RamUsage,   r.cpu_time CPUTime,   r.total_elapsed_time TotalTime,   cast(r.total_elapsed_time AS MONEY) / 60000 AS Duration,   s.program_name ProgramName  from sys.dm_exec_requests r  inner join sys.dm_exec_sessions s  on r.session_id = s.session_id  left join sys.dm_exec_connections c  on r.session_id = c.session_id  outer apply sys.dm_exec_sql_text(r.sql_handle) st  where st.text is not null  ORDER BY total_elapsed_time DESC");
            LastQueries = result.ToList();
            return LastQueries;
        }

        public Task<dynamic> SaveCurrentReport()
        {
            throw new NotImplementedException();
        }
    }
}
