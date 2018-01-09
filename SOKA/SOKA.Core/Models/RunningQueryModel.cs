using SOKA.Core.Metrics;

namespace SOKA.Core.Models
{
    public class RunningQueryModel:IMetricResultDetails
    {
        public int SessionId { get; set; }
        public decimal PercentComplete { get; set; }
        public string LoginName { get; set; }
        public string IP { get; set; }
        public string HostName { get; set; }
        public string DbName { get; set; }
        public string QueryText { get; set; }
        public string Status { get; set; }
        public string Command { get; set; }
        public decimal RamUsage { get; set; }
        public decimal CPUTime { get; set; }
        public decimal TotalTime { get; set; }
        public decimal Duration { get; set; }
        public string ProgramName { get; set; }
        public double MetricValue { get; set; }
    }
}
