using SOKA.Core.Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOKA.Core.MSSQLMonitoring
{
    public class MSSQLMonitorDispatcher : IMetricDispatcher
    {
        private IDBManager DbManager;
        public MSSQLMonitorDispatcher(IDBManager db)
        {
            DbManager = db;
        }
        public async Task<Tuple<T, IEnumerable<dynamic>>> ExecuteAsync<T>(string script) where T : IMetricResult, new() 
        {
            var before = DateTime.UtcNow;
            var value = await DbManager.Execute<dynamic>(script);
            var after = DateTime.UtcNow;
            T dx = new T();
            dx.UtcCaptureTime = before;
            dx.Delay = after.Subtract(before).TotalSeconds;
            dx.Value =  ExtractField<double,dynamic>("MetricValue",value.FirstOrDefault());
            return Tuple.Create(dx, value);
        }

        public T ExtractField<T,K>(string Name,K resultset)
        {
            return (T)Convert.ChangeType((((IDictionary<string, object>)resultset))["MetricValue"],typeof(T));
        }
    }
}
