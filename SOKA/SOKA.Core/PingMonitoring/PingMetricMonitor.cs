using SOKA.Core.Metrics;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SOKA.Core.PingMonitoring
{
    public class PingMetricMonitor : IMetricMonitor
    {
        public IMetricDispatcher Dispatcher { get; set; }
        public IDBManager DbManager { get; set; }

        public event EventHandler<IMetricResult> OnMetricUpdated;
        private IMonitorableMetric bindedMetric;
        private void fireUpdateMetric(IMetricResult result)
        {
            var handle = OnMetricUpdated;
            handle?.Invoke(this, result);
        }
        public IMetricMonitor BindToMetric(IMonitorableMetric metric)
        {
            bindedMetric = metric;
            return this;
        }
        public PingMetricMonitor()
        {
            DbManager = new SQLDbManager(".", 1433, "master", "sa", "123456789");
            Dispatcher = new PingMonitorDispatcher();
        }
        public async Task<Tuple<T, IEnumerable<dynamic>>> GetMetricAsync<T>(string script) where T : IMetricResult, new()
        {
            return await Dispatcher.ExecuteAsync<T>(script);
        }

        public Task<Tuple<T, IEnumerable<dynamic>>> GetMetricAsync<T>() where T : IMetricResult, new()
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<IMetricResult, IEnumerable<dynamic>>> GetMetricAsync(string script)
        {
            throw new NotImplementedException();
        }

        public void Monitor()
        {
            Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    if (bindedMetric != null)
                    {

                        var result = await GetMetricAsync<MetricResult>(string.Format(bindedMetric.Format, bindedMetric.Args));
                        await Task.Factory.StartNew(() => { fireUpdateMetric(result.Item1); });
                        Thread.Sleep(bindedMetric.Interval);
                    }
                    Thread.Sleep(3000);
                }
            });
        }

        public bool SaveMetric<TMetric>(TMetric metric) where TMetric : IMonitorableMetric
        {
            throw new NotImplementedException();
        }

        public bool SaveMetric()
        {
            throw new NotImplementedException();
        }
    }
}
