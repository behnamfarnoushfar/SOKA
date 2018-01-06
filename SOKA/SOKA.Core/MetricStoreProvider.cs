using System;
using SOKA.Core.Metrics;

namespace SOKA.Core
{
    public class MetricStoreProvider
    {
        public static MetricStoreProvider Build(IMetricStoreProvider stroreProvider) { return new MetricStoreProvider(stroreProvider); }
        public IMetricStoreProvider Provider { get; set; }
        public MetricStoreProvider(IMetricStoreProvider provider)
        {
            Provider = provider;
        }
        public IMetricDispatcher BuildDispatcher(IMonitorableMetric metric,IDBManager dbmanager)
        {
            switch (metric.MetricType)
            {
                case MetricTypes.uknown:
                    return null;
                case MetricTypes.MSSQLServer:
                    return new MSSQLMonitoring.MSSQLMonitorDispatcher(dbmanager);
                case MetricTypes.HTTP:
                    return null;
                case MetricTypes.Network:
                    return null;
                default:
                    return null;
            }
        }
    }
}
