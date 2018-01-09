using SOKA.Core.Metrics;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SOKA.Core
{
    public interface IMetricDispatcher
    {
        Task<Tuple<T, IEnumerable<dynamic>>> ExecuteAsync<T>(string script) where T : IMetricResult, new();
        T ExtractField<T,K>(string Name, K resultSet);
    }
}
