using SOKA.Core.Metrics;
using System;
using System.Collections.Generic;

namespace SOKA.Core
{
    public class SOKA
    {
        private static Lazy<SOKA> _instance = new Lazy<SOKA>(() => new SOKA());
        public static SOKA Instance { get { return _instance.Value; } }
        public static SOKA Factory { get { return new SOKA(); } }

        public IMetricDispatcher Dispatcher { get; set; }
        public IDBManager DbaManager { get; set; }
        public IMetricStoreProvider StorePrivder { get; set; }
        public List<IMetricMonitor> Monitors { get; set; }
        public SOKA BuildStore(IMetricStoreProvider storePrivder)
        {
            StorePrivder = storePrivder;
            return this;
        }
        public SOKA BuildDispatcher(IMetricDispatcher dispatcher)
        {
            Dispatcher = dispatcher;
            return this;
        }
        public SOKA BuildDbManager(IDBManager dbManager)
        {
            DbaManager = dbManager;
            return this;
        }
        public IMetricMonitor BuildMonitor(IMonitorableMetric metric)
        {
            IMetricMonitor newMonitor;
            switch (metric.MetricType)
            {
                case MetricTypes.uknown:
                    return null;
                case MetricTypes.MSSQLServer:
                    newMonitor = new MSSQLMonitoring.MSSQLMetricMonitor();
                    break;
                case MetricTypes.HTTP:
                    return null;
                case MetricTypes.Network:
                    return null;
                default:
                    return null;
            }
            if (Monitors == null)
                Monitors = new List<IMetricMonitor>();
            Monitors.Add(newMonitor);
            return newMonitor;
        }
    }
}
