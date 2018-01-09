using SOKA.Core.Metrics;
using SOKA.Core.MSSQLMonitoring.Metrics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOKA.WinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucMetricSummery1.ManualSetProgressCallBack(20, "test", 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucMetricSummery1.ManualSetProgressCallBack(50, "test", 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucMetricSummery1.ManualSetProgressCallBack(80, "test", 80);
        }

        private void ucMetricSummery1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucMetricSummery1.StartProgress(
                new MonitorableMetric()
                {
                    Name = "Queries",
                    Interval = 5000,
                    MetricType = Core.MetricTypes.MSSQLServer,
                    MaxAmount = 100,
                    MinAmount = 0,
                    Format = "select count(1) over() MetricValue,  r.session_id  SessionId,   r.percent_complete PercentComplete,   s.login_name LoginName,   c.client_net_address IP,   s.host_name HostName,   db_name(dbid) as DbName,   st.text QueryText,   r.status Status,   r.command Command,   (SELECT SUM( granted_memory_kb/1024) FROM  sys.dm_exec_query_memory_grants  WHERE sys.dm_exec_query_memory_grants.sql_handle=r.sql_handle ) RamUsage,   r.cpu_time CPUTime,   r.total_elapsed_time TotalTime,   cast(r.total_elapsed_time AS MONEY) / 60000 AS Duration,   s.program_name ProgramName  from sys.dm_exec_requests r  inner join sys.dm_exec_sessions s  on r.session_id = s.session_id  left join sys.dm_exec_connections c  on r.session_id = c.session_id  outer apply sys.dm_exec_sql_text(r.sql_handle) st  where st.text is not null  ORDER BY r.total_elapsed_time DESC"
                }
                );
            ucMetricSummery2.StartProgress(
                new MonitorableMetric()
                {
                    Name = "SQLCpu",
                    Interval = 5000,
                    MetricType = Core.MetricTypes.MSSQLServer,
                    MaxAmount = 100,
                    MinAmount = 0,
                    Format = "select top 1 cntr_value MetricValue from sys.dm_os_performance_counters where counter_name  ='CPU usage %'"
                }
                );
            ucMetricSummery3.StartProgress(
                new MonitorableMetric()
                {
                    Name = "SQLRAM",
                    Interval = 5000,
                    MetricType = Core.MetricTypes.MSSQLServer,
                    MaxAmount = 5000,
                    MinAmount = 0,
                    Format = "select top 1 cntr_value/1024 MetricValue  from sys.dm_os_performance_counters where counter_name=N'Used memory (KB)' and instance_name='default'"
                }
                );
            ucMetricSummery4.StartProgress(
                new MonitorableMetric()
                {
                    Name = "IOLatency",
                    Interval = 5000,
                    MetricType = Core.MetricTypes.MSSQLServer,
                    MaxAmount = 10,
                    MinAmount = 0,
                    Format = "SELECT [MetricValue] = AVG(CASE WHEN ([num_of_reads] = 0 AND [num_of_writes] = 0) THEN 0 ELSE ([io_stall] / ([num_of_reads] + [num_of_writes])) END) over(), [ReadLatency] = CASE WHEN [num_of_reads] = 0 THEN 0 ELSE ([io_stall_read_ms] / [num_of_reads]) END, [WriteLatency] = CASE WHEN [num_of_writes] = 0 THEN 0 ELSE ([io_stall_write_ms] / [num_of_writes]) END, [Latency] = CASE WHEN ([num_of_reads] = 0 AND [num_of_writes] = 0) THEN 0 ELSE ([io_stall] / ([num_of_reads] + [num_of_writes])) END, [AvgBPerRead] = CASE WHEN [num_of_reads] = 0 THEN 0 ELSE ([num_of_bytes_read] / [num_of_reads]) END, [AvgBPerWrite] = CASE WHEN [num_of_writes] = 0 THEN 0 ELSE ([num_of_bytes_written] / [num_of_writes]) END, [AvgBPerTransfer] = CASE WHEN ([num_of_reads] = 0 AND [num_of_writes] = 0) THEN 0 ELSE (([num_of_bytes_read] + [num_of_bytes_written]) / ([num_of_reads] + [num_of_writes])) END, LEFT ([mf].[physical_name], 2) AS [Drive], DB_NAME ([vfs].[database_id]) AS [DB], [mf].[physical_name] FROM sys.dm_io_virtual_file_stats (NULL,NULL) AS [vfs] JOIN sys.master_files AS [mf] ON [vfs].[database_id] = [mf].[database_id] AND [vfs].[file_id] = [mf].[file_id] 	where CASE WHEN ([num_of_reads] = 0 AND [num_of_writes] = 0) THEN 0 ELSE ([io_stall] / ([num_of_reads] + [num_of_writes]))end >0"
                }
                );
            ucMetricSummery5.StartProgress(
                new MonitorableMetric()
                {
                    Name = "DiskUsage",
                    Interval = 5000,
                    MetricType = Core.MetricTypes.MSSQLServer,
                    MaxAmount = 100,
                    MinAmount = 0,
                    Format = "SELECT DISTINCT dovs.volume_mount_point AS Drive, CONVERT(INT,dovs.available_bytes/1048576.0/1024) AS FreeSpaceInMB, CONVERT(INT,dovs.total_bytes/1048576.0/1024) AS TotalSpaceInMB, (CONVERT(INT,dovs.available_bytes/1048576.0/1024) *100)/CONVERT(INT,dovs.total_bytes/1048576.0/1024)MetricValue FROM sys.master_files mf CROSS APPLY sys.dm_os_volume_stats(mf.database_id, mf.FILE_ID) dovs ORDER BY FreeSpaceInMB ASC ",
                    ReversedCheck=true
                }
                );
            ucMetricSummery6.StartProgress(
                new MonitorableMetric()
                {
                    Name = "IndexFragmentation",
                    Interval = 5000,
                    MetricType = Core.MetricTypes.MSSQLServer,
                    MaxAmount = 100,
                    MinAmount = 0,
                    Format = "SELECT db_name(database_id)Db,object_name(object_id)Tbl,page_count Size,avg_fragmentation_in_percent MetricValue FROM sys.dm_db_index_physical_stats (NULL, NULL, NULL, NULL, NULL) where avg_fragmentation_in_percent>30 and page_count>100"
                }
                );
            ucMetricSummery7.StartProgress(
                new MonitorableMetric()
                {
                    Name = "YahooPing",
                    Interval = 5000,
                    MetricType = Core.MetricTypes.Network,
                    MaxAmount = 300,
                    MinAmount = 0,
                    Format = "yahoo.com"
                }
                );
        }
    }


}
