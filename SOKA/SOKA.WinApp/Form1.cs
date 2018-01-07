using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOKA.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucMetricSummery1.ManualSetProgress(20, "test", 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucMetricSummery1.ManualSetProgress(50, "test", 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucMetricSummery1.ManualSetProgress(80, "test", 80);
        }
    }

    
}
