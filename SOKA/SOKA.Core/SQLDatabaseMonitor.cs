using SOKA.Core.MetricStoreProviders;
using SOKA.Core.Models;
using SOKA.Core.MSSQLMonitoring;
using SOKA.Core.MSSQLMonitoring.Metrics;
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
        public List<RunningQueriesResult> LastQueries { get; set; }
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

        MetricStore Store;
        public SQLDatabaseMonitor()
        {
            Store = new MetricStore();
            Store["runningqueries"] = "select   r.session_id  SessionId,   r.percent_complete PercentComplete,   s.login_name LoginName,   c.client_net_address IP,   s.host_name HostName,   db_name(dbid) as DbName,   st.text QueryText,   r.status Status,   r.command Command,   (SELECT SUM( granted_memory_kb/1024) FROM  sys.dm_exec_query_memory_grants  WHERE sys.dm_exec_query_memory_grants.sql_handle=r.sql_handle ) RamUsage,   r.cpu_time CPUTime,   r.total_elapsed_time TotalTime,   cast(r.total_elapsed_time AS MONEY) / 60000 AS Duration,   s.program_name ProgramName  from sys.dm_exec_requests r  inner join sys.dm_exec_sessions s  on r.session_id = s.session_id  left join sys.dm_exec_connections c  on r.session_id = c.session_id  outer apply sys.dm_exec_sql_text(r.sql_handle) st  where st.text is not null  ORDER BY r.total_elapsed_time DESC";
        }
        public async Task DoMonitoring()
        {
            await Task.Factory.StartNew(async () =>
             {
                 while (true)
                 {
                     SOKA.Instance.BuildStore(new InMemoryDictionaryProvider())
                     .BuildDbManager(new SQLDbManager(".", 1433, "msdb", "sa", "1234567"))
                     .BuildDispatcher(new MSSQLMonitorDispatcher(SOKA.Instance.DbaManager));
                     var metrics=await SOKA.Instance.StorePrivder.GetMetrics();
                     foreach (var metric in metrics)
                     {
                         SOKA.Instance.BuildMonitor(metric).BindToMetric(metric);
                     }

                     foreach (var monitor in SOKA.Instance.Monitors)
                     {
                         var resul=await monitor.GetMetricAsync<RunningQueriesResult,RunningQueryModel>();
                     }
                     //var result = await GetRunningQueriesAsync();
                     //OnInstanceConnected(this, null);
                     //if (result.Count > QueryCountThreshold)
                     //    OnQueryCountThresholdExceeded(this, new { QueriesCount = result.Count });
                     //if (result.Count(x => x.TotalTime > QueryTimeThreshold) > 0)
                     //    OnQueryTimeThresholdExceeded(this, new { AvgExceededtime = result.Where(x => x.TotalTime > QueryTimeThreshold).Average(x=>x.TotalTime) });
                     //Thread.Sleep(InstanceCheckStatusInterval);
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

        public async Task<List<RunningQueriesResult>> GetRunningQueriesAsync()
        {
            //MSSQLMetricMonitor sqlmonitor = new MSSQLMetricMonitor();
            //var metric = await sqlmonitor.GetMetricAsync<RunningQueries, RunningQueryModel>(Store["runningqueries"]);
            //var result = metric.Item2;
            //LastQueries = result.ToList();
            ////sqlmonitor.SaveMetric(metric)
            //return LastQueries;
            return null;
        }

        public Task<dynamic> SaveCurrentReport()
        {
            throw new NotImplementedException();
        }

    }
}
