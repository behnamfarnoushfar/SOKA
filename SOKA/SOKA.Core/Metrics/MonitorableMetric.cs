using System;

namespace SOKA.Core.Metrics
{
    public class MonitorableMetric : IMonitorableMetric
    {
        public int Id { get; set; }
        public string TargetHost { get; set; }
        public int TargetPort { get; set; }
        public string Label { get; set; }
        public float MaxAmount { get; set; }
        public float MinAmount { get; set; }
        public float TimeOut { get; set; }
        public int AlertRate { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Interval { get; set; }
        public string Format { get; set; }
        public string Args { get; set; }
        public MetricTypes MetricType { get; set; }
        public bool ReversedCheck { get; set; }
    }
}
