using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOKA.Core
{
    public interface IDBPerformanceAdvisor
    {
        Task<dynamic> AnalyseDatabasePerformance(IDBManager db);
    }
}
