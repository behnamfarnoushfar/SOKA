using SOKA.Core.Metrics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SOKA.Core.MetricStoreProviders
{
    public class InMemoryDictionaryProvider : IMetricStoreProvider
    {
        private static Dictionary<string, string> _store = new Dictionary<string, string>();
        private static List<IMetricResult> _metricResultStore = new List<IMetricResult>();
        private static List<IMonitorableMetric> _metricStore = new List<IMonitorableMetric>();
        public string this[string index]
        {
            get { return _store.ContainsKey(index) ? _store[index] : null; }
            set { if (_store.ContainsKey(index)) _store.Add(index, value); else _store[index] = value; }
        }

        public Task<List<IMonitorableMetric>> GetMetrics()
        {
            return Task.FromResult(_metricStore);
        }

        public Task<List<IMetricResult>> GetResults()
        {
            return Task.FromResult(_metricResultStore);
        }
    }
}
