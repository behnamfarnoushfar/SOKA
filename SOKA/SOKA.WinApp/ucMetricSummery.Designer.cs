namespace SOKA.WinApp
{
    partial class ucMetricSummery
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.npbMetricLevel = new SOKA.WinApp.NewProgressBar();
            this.lblMetricName = new System.Windows.Forms.Label();
            this.lblMetricValue = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnDtl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // npbMetricLevel
            // 
            this.npbMetricLevel.Location = new System.Drawing.Point(0, 22);
            this.npbMetricLevel.Name = "npbMetricLevel";
            this.npbMetricLevel.ProgressColor = null;
            this.npbMetricLevel.Size = new System.Drawing.Size(128, 23);
            this.npbMetricLevel.TabIndex = 0;
            this.npbMetricLevel.Click += new System.EventHandler(this.npbMetricLevel_Click);
            // 
            // lblMetricName
            // 
            this.lblMetricName.AutoSize = true;
            this.lblMetricName.Location = new System.Drawing.Point(40, 6);
            this.lblMetricName.Name = "lblMetricName";
            this.lblMetricName.Size = new System.Drawing.Size(35, 13);
            this.lblMetricName.TabIndex = 1;
            this.lblMetricName.Text = "label1";
            // 
            // lblMetricValue
            // 
            this.lblMetricValue.AutoSize = true;
            this.lblMetricValue.BackColor = System.Drawing.Color.Transparent;
            this.lblMetricValue.Location = new System.Drawing.Point(93, 54);
            this.lblMetricValue.Name = "lblMetricValue";
            this.lblMetricValue.Size = new System.Drawing.Size(35, 13);
            this.lblMetricValue.TabIndex = 2;
            this.lblMetricValue.Text = "label2";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(0, 49);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(42, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnDtl
            // 
            this.btnDtl.Location = new System.Drawing.Point(43, 49);
            this.btnDtl.Name = "btnDtl";
            this.btnDtl.Size = new System.Drawing.Size(42, 23);
            this.btnDtl.TabIndex = 4;
            this.btnDtl.Text = "Details";
            this.btnDtl.UseVisualStyleBackColor = true;
            // 
            // ucMetricSummery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnDtl);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblMetricValue);
            this.Controls.Add(this.lblMetricName);
            this.Controls.Add(this.npbMetricLevel);
            this.Name = "ucMetricSummery";
            this.Size = new System.Drawing.Size(131, 75);
            this.Load += new System.EventHandler(this.ucMetricSummery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinApp.NewProgressBar npbMetricLevel;
        private System.Windows.Forms.Label lblMetricName;
        private System.Windows.Forms.Label lblMetricValue;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnDtl;
    }
}
