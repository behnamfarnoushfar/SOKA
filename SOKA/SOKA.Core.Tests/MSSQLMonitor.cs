using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOKA.Core.MSSQLMonitoring;
using SOKA.Core.MSSQLMonitoring.Metrics;
using SOKA.Core.Models;

namespace SOKA.Core.Tests
{
    [TestClass]
    public class MSSQLMonitor
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result=SOKA.Instance
                .BuildMonitor(new RunningQueries() { MetricType=MetricTypes.MSSQLServer })
                .GetMetricAsync<RunningQueriesResult>
                ("select   r.session_id  SessionId,   r.percent_complete PercentComplete,   s.login_name LoginName,   c.client_net_address IP,   s.host_name HostName,   db_name(dbid) as DbName,   st.text QueryText,   r.status Status,   r.command Command,   (SELECT SUM( granted_memory_kb/1024) FROM  sys.dm_exec_query_memory_grants  WHERE sys.dm_exec_query_memory_grants.sql_handle=r.sql_handle ) RamUsage,   r.cpu_time CPUTime,   r.total_elapsed_time TotalTime,   cast(r.total_elapsed_time AS MONEY) / 60000 AS Duration,   s.program_name ProgramName  from sys.dm_exec_requests r  inner join sys.dm_exec_sessions s  on r.session_id = s.session_id  left join sys.dm_exec_connections c  on r.session_id = c.session_id  outer apply sys.dm_exec_sql_text(r.sql_handle) st  where st.text is not null  ORDER BY r.total_elapsed_time DESC")
                .Result;
        }
    }
}
