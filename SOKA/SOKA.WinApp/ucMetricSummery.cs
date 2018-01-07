using SOKA.Core.Metrics;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOKA.WinApp
{
    public partial class ucMetricSummery : UserControl
    {
        public IMonitorableMetric Metric { get; set; }
        public ucMetricSummery()
        {
            InitializeComponent();
        }

        public void ManualSetProgress(double Value,string MetricName,double Max)
        {
            var percent = Value * 100 / Max;
            if (percent <= 40)
            {
                lblMetricName.Text = MetricName;
                lblMetricName.ForeColor = Color.Green;
                npbMetricLevel.ProgressColor = Brushes.Green;
                lblMetricValue.Text = Value.ToString();
                lblMetricValue.ForeColor = Color.Green;
            }
            else if (percent > 40 && percent <= 70)
            {
                lblMetricName.Text = MetricName;
                lblMetricName.ForeColor = Color.Yellow;
                npbMetricLevel.ProgressColor = Brushes.Yellow;
                lblMetricValue.Text = Value.ToString();
                lblMetricValue.ForeColor = Color.Yellow;
            }
            else
            {
                lblMetricName.Text = MetricName;
                lblMetricName.ForeColor = Color.Red;
                npbMetricLevel.ProgressColor = Brushes.Red;
                lblMetricValue.Text = Value.ToString();
                lblMetricValue.ForeColor = Color.Red;
            }
            npbMetricLevel.Value = (int)Value;
        }

        private void ucMetricSummery_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    var result = await Core.SOKA.Instance.BuildMonitor(Metric)
                    .GetMetricAsync(string.Format(Metric.Format, Metric.Args));
                    ManualSetProgress(result.Item1.Value, Metric.Name,Metric.MaxAmount);
                    Thread.Sleep(Metric.Interval);
                }
            });
        }
    }
}
