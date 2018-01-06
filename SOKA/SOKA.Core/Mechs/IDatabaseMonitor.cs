using SOKA.Core.Models;
using SOKA.Core.MSSQLMonitoring.Metrics;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SOKA.Core
{
    public interface IDatabaseMonitor
    {
       IDBManager Database { get; set; }
        int QueryTimeThreshold { get; set; }
        int QueryCountThreshold { get; set; }
        int LockTimeThreshold { get; set; }
        int LockCountThreshold { get; set; }
        int CPUUsageThreshold { get; set; }
        int RAMUsageThreashold { get; set; }
        int IOUsageThreshold { get; set; }
        int StorageUsageThreashold { get; set; }
        int InstanceCheckStatusInterval { get; set; }
        int IndexCheckStatusInterval { get; set; }
        int ReplicationStatusCheckInterval { get; set; }
        List<string> IndexCheckNames { get; set; }
        List<RunningQueriesResult> LastQueries { get; set; }
        List<dynamic> LastLocks { get; set; }
        List<dynamic> LastMetrics { get; set; }
        List<dynamic> LastIndexStatuses { get; set; }
        List<dynamic> LastReplicationStats { get; set; }
        DateTime LastRun { get; set; }

        Task DoMonitoring();
        Task<dynamic> SaveCurrentReport();
        Task<List<RunningQueriesResult>> GetRunningQueriesAsync();
        Task<List<dynamic>> GetRunningLocks();
        Task<List<dynamic>> GetCurrentMetrics();
        Task<List<dynamic>> GetReplicationStatuses();
        Task<List<dynamic>> GetIndexStatuses();



        event EventHandler<dynamic> OnInstanceConnected;
        event EventHandler<dynamic> OnInstanceDisConnected;
        event EventHandler<dynamic> OnQueryCountThresholdExceeded;
        event EventHandler<dynamic> OnQueryTimeThresholdExceeded;
        event EventHandler<dynamic> OnLockCountExceeded;
        event EventHandler<dynamic> OnLockTimeExceeded;
        event EventHandler<dynamic> OnStorageExceeded;
        event EventHandler<dynamic> OnCPUExceeded;
        event EventHandler<dynamic> OnRAMExceeded;
        event EventHandler<dynamic> OnIOExceeded;
        event EventHandler<dynamic> OnSensetiveDataDetected;
        event EventHandler<dynamic> OnAlterOccured;
    }
}
