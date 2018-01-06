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
        public async Task<Tuple<T, IEnumerable<K>>> ExecuteAsync<T, K>(string script) where T : IMetricResult, new()
        {
            var before = DateTime.UtcNow;
            var value = await DbManager.Execute<K>(script);
            var after = DateTime.UtcNow;
            T dx = new T();
            dx.UtcCaptureTime = before;
            dx.Delay = after.Subtract(before).TotalSeconds;
            dx.Value = value.Count();
            return Tuple.Create(dx, value);
        }
    }
}
