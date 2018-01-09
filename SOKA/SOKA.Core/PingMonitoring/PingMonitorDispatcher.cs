using SOKA.Core.Metrics;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace SOKA.Core.PingMonitoring
{
    public class PingMonitorDispatcher : IMetricDispatcher
    {
        public Task<Tuple<T, IEnumerable<dynamic>>> ExecuteAsync<T>(string script) where T : IMetricResult, new()
        {
            Ping ping = new Ping();
            PingOptions options = new PingOptions(128,true);
            var before = DateTime.UtcNow;
            PingReply reply = ping.Send(script, 30000, new byte[] { 0x1 }, options);
            var after = DateTime.UtcNow;
            T result = new T();
            result.Delay = after.Subtract(before).TotalSeconds;
            result.UtcCaptureTime = before;
            result.Value = reply.Status==IPStatus.Success? reply.RoundtripTime:double.MaxValue;
            IEnumerable<dynamic> r = new List<dynamic>();
            return Task.FromResult(Tuple.Create(result, r));
        }

        public T ExtractField<T, K>(string Name, K resultSet)
        {
            throw new NotImplementedException();
        }
    }
}
