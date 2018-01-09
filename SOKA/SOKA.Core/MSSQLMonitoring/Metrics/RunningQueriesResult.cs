using SOKA.Core.Metrics;
using System;

namespace SOKA.Core.MSSQLMonitoring.Metrics
{
    public class RunningQueriesResult : IMetricResult
    {
        public int Id { get; set; }
        public bool TimedOut { get; set; }
        public bool NoDNS { get; set; }
        public bool NoNetwork { get; set; }
        public double Value { get; set; }
        public DateTime UtcCaptureTime { get; set; }
        public double Delay { get; set; }
        public IMetricResultDetails MetricData { get; set; }
    }
}
