using System;

namespace SOKA.Core.Metrics
{
    public class MetricResult : IMetricResult
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool TimedOut { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool NoDNS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool NoNetwork { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UtcCaptureTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Delay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public dynamic MetricData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
