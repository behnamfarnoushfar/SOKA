using SOKA.Core.Metrics;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SOKA.Core.MSSQLMonitoring
{
    public class MSSQLMetricMonitor : IMetricMonitor
    {
        public MSSQLMonitorDispatcher Dispatcher { get; set; }
        public SQLDbManager DbManager { get; set; }
        IMetricDispatcher IMetricMonitor.Dispatcher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IDBManager IMetricMonitor.DbManager { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private IMonitorableMetric bindedMetric;
        public MSSQLMetricMonitor()
        {
            DbManager = new SQLDbManager(".",1433,"master","sa","123456789");
            Dispatcher = new MSSQLMonitorDispatcher(DbManager);
        }

        public async Task<Tuple<T, IEnumerable<K>>> GetMetricAsync<T,K>(string script) where T : IMetricResult,new()
        {
            return await Dispatcher.ExecuteAsync<T,K>(script);
        }

        public bool SaveMetric<TMetric>(TMetric metric) where TMetric : IMonitorableMetric
        {
            throw new NotImplementedException();
        }

        public void BindToMetric(IMonitorableMetric metric)
        {
            bindedMetric = metric;
        }

        public async Task<Tuple<T, IEnumerable<K>>> GetMetricAsync<T, K>() where T : IMetricResult, new()
        {
            return await GetMetricAsync<T, K>(string.Format(bindedMetric.Format,bindedMetric.Args));
        }

        public bool SaveMetric()
        {
            throw new NotImplementedException();
        }
    }
}
