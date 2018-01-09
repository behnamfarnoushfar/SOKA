using SOKA.Core.Metrics;
using SOKA.Core.MSSQLMonitoring.Metrics;
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

        delegate void ManualSetProgress(double Value, string MetricName, double Max);
        public void StartProgress(IMonitorableMetric metric)
        {
            Metric = metric;
            var mtr = Core.SOKA.Instance.BuildMonitor(Metric).BindToMetric(Metric);
            mtr.OnMetricUpdated += Mtr_OnMetricUpdated;
            mtr.Monitor();
        }
        public void ManualSetProgressCallBack(double Value,string MetricName,double Max)
        {
            if(lblMetricName.InvokeRequired)
            {
                var callback = new ManualSetProgress(ManualSetProgressCallBack);
                lblMetricName.Invoke(callback, new object[] { Value, MetricName, Max });
            }
            else
            {
                UpdateUI(Value, MetricName, Max);
            }
            
        }

        private void UpdateUI(double Value, string MetricName, double Max)
        {
            var percent = (Metric.ReversedCheck?Max-Value: Value) * 100 / Max;
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
                lblMetricName.ForeColor = Color.Orange;
                npbMetricLevel.ProgressColor = Brushes.Orange;
                lblMetricValue.Text = Value.ToString();
                lblMetricValue.ForeColor = Color.Orange;
            }
            else
            {
                lblMetricName.Text = MetricName;
                lblMetricName.ForeColor = Color.Red;
                npbMetricLevel.ProgressColor = Brushes.Red;
                lblMetricValue.Text = Value.ToString();
                lblMetricValue.ForeColor = Color.Red;
            }
            if (percent > npbMetricLevel.Maximum)
                npbMetricLevel.Value = npbMetricLevel.Maximum;
            else
                npbMetricLevel.Value =(int)percent;
          
        }

        private void ucMetricSummery_Load(object sender, EventArgs e)
        {
           
        }

        private void Mtr_OnMetricUpdated(object sender, IMetricResult e)
        {
            ManualSetProgressCallBack(e.Value/*r.Next(1, 100)*/, Metric.Name, Metric.MaxAmount);
        }
        Random r = new Random();
        private void npbMetricLevel_Click(object sender, EventArgs e)
        {

        }
    }
}
