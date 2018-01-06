using SOKA.Core.Metrics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SOKA.Core
{
    public interface IMetricStoreProvider
    {
        Task<List<IMonitorableMetric>> GetMetrics();
        Task<List<IMetricResult>> GetResults();
    }
}
