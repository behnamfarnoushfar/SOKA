using SOKA.Core.Metrics;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SOKA.Core
{
    public interface IMetricMonitor
    {
        Task<Tuple<T, IEnumerable<K>>> GetMetricAsync<T,K>(string script) where T : IMetricResult, new();
        Task<Tuple<T, IEnumerable<K>>> GetMetricAsync<T, K>() where T : IMetricResult, new();
        bool SaveMetric<TMetric>(TMetric metric) where TMetric : IMonitorableMetric;
        bool SaveMetric();
        IMetricDispatcher Dispatcher { get; set; }
        IDBManager DbManager { get; set; }
        void BindToMetric(IMonitorableMetric metric);
    }
}
