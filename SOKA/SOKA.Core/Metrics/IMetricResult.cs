using System;

namespace SOKA.Core.Metrics
{
    public interface IMetricResult
    {
        int Id { get; set; }
        bool TimedOut { get; set; }
        bool NoDNS { get; set; }
        bool NoNetwork { get; set; }
        double Value { get; set; }
        DateTime UtcCaptureTime { get; set; }
        double Delay { get; set; }
        dynamic MetricData { get; set; }
    }
}
