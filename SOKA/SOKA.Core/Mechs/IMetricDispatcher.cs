using SOKA.Core.Metrics;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SOKA.Core
{
    public interface IMetricDispatcher
    {
        Task<Tuple<T, IEnumerable<K>>> ExecuteAsync<T,K>(string script) where T : IMetricResult,new();
    }
}
