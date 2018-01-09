using System;

namespace SOKA.Core.Metrics
{
    public interface IMonitorableMetric
    {
        int Id { get; set; }
        string TargetHost { get; set; }
        int TargetPort { get; set; }
        string Label { get; set; }
        float MaxAmount { get; set; }
        float MinAmount { get; set; }
        float TimeOut { get; set; }
        int AlertRate { get; set; }
        string Name { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        TimeSpan StartTime { get; set; }
        TimeSpan EndTime { get; set; }
        int Interval { get; set; }
        string Format { get; set; }
        string Args { get; set; }
        bool ReversedCheck { get; set; }
        MetricTypes MetricType { get; set; }
    }
}
