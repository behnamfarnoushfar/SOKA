namespace SOKA.WinApp
{
    partial class frmSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMetrics = new System.Windows.Forms.TabControl();
            this.tpStorageSettings = new System.Windows.Forms.TabPage();
            this.tpMetrics = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbMetrics = new System.Windows.Forms.ListBox();
            this.btnSaveMetric = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlertRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMetricType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStoragePassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStorageUsername = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtStoragePort = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStorageHost = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtStorageName = new System.Windows.Forms.TextBox();
            this.cbStorageType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnConnectToStorage = new System.Windows.Forms.Button();
            this.tpMonitors = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnStopMonitoring = new System.Windows.Forms.Button();
            this.btnResumeMonitoring = new System.Windows.Forms.Button();
            this.tabMetrics.SuspendLayout();
            this.tpStorageSettings.SuspendLayout();
            this.tpMetrics.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpMonitors.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMetrics
            // 
            this.tabMetrics.Controls.Add(this.tpStorageSettings);
            this.tabMetrics.Controls.Add(this.tpMetrics);
            this.tabMetrics.Controls.Add(this.tpMonitors);
            this.tabMetrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMetrics.Location = new System.Drawing.Point(0, 0);
            this.tabMetrics.Name = "tabMetrics";
            this.tabMetrics.SelectedIndex = 0;
            this.tabMetrics.Size = new System.Drawing.Size(971, 520);
            this.tabMetrics.TabIndex = 0;
            // 
            // tpStorageSettings
            // 
            this.tpStorageSettings.Controls.Add(this.btnConnectToStorage);
            this.tpStorageSettings.Controls.Add(this.label20);
            this.tpStorageSettings.Controls.Add(this.cbStorageType);
            this.tpStorageSettings.Controls.Add(this.label15);
            this.tpStorageSettings.Controls.Add(this.txtStoragePassword);
            this.tpStorageSettings.Controls.Add(this.label16);
            this.tpStorageSettings.Controls.Add(this.txtStorageUsername);
            this.tpStorageSettings.Controls.Add(this.label17);
            this.tpStorageSettings.Controls.Add(this.txtStoragePort);
            this.tpStorageSettings.Controls.Add(this.label18);
            this.tpStorageSettings.Controls.Add(this.txtStorageHost);
            this.tpStorageSettings.Controls.Add(this.label19);
            this.tpStorageSettings.Controls.Add(this.txtStorageName);
            this.tpStorageSettings.Location = new System.Drawing.Point(4, 22);
            this.tpStorageSettings.Name = "tpStorageSettings";
            this.tpStorageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpStorageSettings.Size = new System.Drawing.Size(963, 494);
            this.tpStorageSettings.TabIndex = 0;
            this.tpStorageSettings.Text = "StorageSetting";
            this.tpStorageSettings.UseVisualStyleBackColor = true;
            // 
            // tpMetrics
            // 
            this.tpMetrics.Controls.Add(this.groupBox2);
            this.tpMetrics.Controls.Add(this.groupBox1);
            this.tpMetrics.Location = new System.Drawing.Point(4, 22);
            this.tpMetrics.Name = "tpMetrics";
            this.tpMetrics.Padding = new System.Windows.Forms.Padding(3);
            this.tpMetrics.Size = new System.Drawing.Size(963, 494);
            this.tpMetrics.TabIndex = 1;
            this.tpMetrics.Text = "Metrics";
            this.tpMetrics.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbMetrics);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbMetricType);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAlertRate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTimeOut);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtInterval);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMax);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtHost);
            this.groupBox2.Controls.Add(this.mtName);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.btnSaveMetric);
            this.groupBox2.Location = new System.Drawing.Point(296, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 488);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lsbMetrics
            // 
            this.lsbMetrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbMetrics.FormattingEnabled = true;
            this.lsbMetrics.Location = new System.Drawing.Point(3, 16);
            this.lsbMetrics.Name = "lsbMetrics";
            this.lsbMetrics.Size = new System.Drawing.Size(265, 469);
            this.lsbMetrics.TabIndex = 0;
            // 
            // btnSaveMetric
            // 
            this.btnSaveMetric.Location = new System.Drawing.Point(307, 210);
            this.btnSaveMetric.Name = "btnSaveMetric";
            this.btnSaveMetric.Size = new System.Drawing.Size(75, 77);
            this.btnSaveMetric.TabIndex = 0;
            this.btnSaveMetric.Text = "Save";
            this.btnSaveMetric.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 1;
            // 
            // mtName
            // 
            this.mtName.AutoSize = true;
            this.mtName.Location = new System.Drawing.Point(6, 32);
            this.mtName.Name = "mtName";
            this.mtName.Size = new System.Drawing.Size(64, 13);
            this.mtName.TabIndex = 2;
            this.mtName.Text = "MetricName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(86, 55);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(135, 20);
            this.txtHost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(86, 81);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(135, 20);
            this.txtPort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(86, 107);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(135, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 133);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "StartDateTime";
            // 
            // txtAlertRate
            // 
            this.txtAlertRate.Location = new System.Drawing.Point(488, 133);
            this.txtAlertRate.Name = "txtAlertRate";
            this.txtAlertRate.Size = new System.Drawing.Size(135, 20);
            this.txtAlertRate.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "TimeOut";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(488, 107);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(135, 20);
            this.txtTimeOut.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Interval";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(488, 81);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(135, 20);
            this.txtInterval.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "MaxAmount";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(488, 55);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(135, 20);
            this.txtMax.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "MinAmount";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(488, 29);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(135, 20);
            this.txtMin.TabIndex = 11;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(86, 214);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 21;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(86, 240);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "EndDateTime";
            // 
            // cbMetricType
            // 
            this.cbMetricType.FormattingEnabled = true;
            this.cbMetricType.Items.AddRange(new object[] {
            "MSSQLServer"});
            this.cbMetricType.Location = new System.Drawing.Point(86, 266);
            this.cbMetricType.Name = "cbMetricType";
            this.cbMetricType.Size = new System.Drawing.Size(200, 21);
            this.cbMetricType.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "MetricType";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(408, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "AlertRate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 368);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(646, 112);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 307);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(646, 38);
            this.textBox2.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Arguments";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Script";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(393, 210);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 77);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Password";
            // 
            // txtStoragePassword
            // 
            this.txtStoragePassword.Location = new System.Drawing.Point(89, 110);
            this.txtStoragePassword.Name = "txtStoragePassword";
            this.txtStoragePassword.Size = new System.Drawing.Size(135, 20);
            this.txtStoragePassword.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "UserName";
            // 
            // txtStorageUsername
            // 
            this.txtStorageUsername.Location = new System.Drawing.Point(89, 84);
            this.txtStorageUsername.Name = "txtStorageUsername";
            this.txtStorageUsername.Size = new System.Drawing.Size(135, 20);
            this.txtStorageUsername.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Port";
            // 
            // txtStoragePort
            // 
            this.txtStoragePort.Location = new System.Drawing.Point(89, 58);
            this.txtStoragePort.Name = "txtStoragePort";
            this.txtStoragePort.Size = new System.Drawing.Size(135, 20);
            this.txtStoragePort.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Host";
            // 
            // txtStorageHost
            // 
            this.txtStorageHost.Location = new System.Drawing.Point(89, 32);
            this.txtStorageHost.Name = "txtStorageHost";
            this.txtStorageHost.Size = new System.Drawing.Size(135, 20);
            this.txtStorageHost.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Name";
            // 
            // txtStorageName
            // 
            this.txtStorageName.Location = new System.Drawing.Point(89, 6);
            this.txtStorageName.Name = "txtStorageName";
            this.txtStorageName.Size = new System.Drawing.Size(135, 20);
            this.txtStorageName.TabIndex = 11;
            // 
            // cbStorageType
            // 
            this.cbStorageType.FormattingEnabled = true;
            this.cbStorageType.Items.AddRange(new object[] {
            "MSSQLServer"});
            this.cbStorageType.Location = new System.Drawing.Point(89, 137);
            this.cbStorageType.Name = "cbStorageType";
            this.cbStorageType.Size = new System.Drawing.Size(135, 21);
            this.cbStorageType.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "StorageType";
            // 
            // btnConnectToStorage
            // 
            this.btnConnectToStorage.Location = new System.Drawing.Point(89, 164);
            this.btnConnectToStorage.Name = "btnConnectToStorage";
            this.btnConnectToStorage.Size = new System.Drawing.Size(135, 38);
            this.btnConnectToStorage.TabIndex = 23;
            this.btnConnectToStorage.Text = "Connect";
            this.btnConnectToStorage.UseVisualStyleBackColor = true;
            // 
            // tpMonitors
            // 
            this.tpMonitors.Controls.Add(this.groupBox5);
            this.tpMonitors.Controls.Add(this.groupBox4);
            this.tpMonitors.Controls.Add(this.groupBox3);
            this.tpMonitors.Location = new System.Drawing.Point(4, 22);
            this.tpMonitors.Name = "tpMonitors";
            this.tpMonitors.Padding = new System.Windows.Forms.Padding(3);
            this.tpMonitors.Size = new System.Drawing.Size(963, 494);
            this.tpMonitors.TabIndex = 2;
            this.tpMonitors.Text = "Monitors";
            this.tpMonitors.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 488);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 469);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Location = new System.Drawing.Point(285, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 488);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 16);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(265, 469);
            this.listBox2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnResumeMonitoring);
            this.groupBox5.Controls.Add(this.btnStopMonitoring);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Location = new System.Drawing.Point(563, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(392, 484);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "UserName";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "Port";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(90, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(135, 20);
            this.textBox5.TabIndex = 15;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "Host";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(90, 49);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 12;
            this.label25.Text = "MetricName";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(90, 23);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(135, 20);
            this.textBox7.TabIndex = 11;
            // 
            // btnStopMonitoring
            // 
            this.btnStopMonitoring.Location = new System.Drawing.Point(90, 163);
            this.btnStopMonitoring.Name = "btnStopMonitoring";
            this.btnStopMonitoring.Size = new System.Drawing.Size(135, 43);
            this.btnStopMonitoring.TabIndex = 21;
            this.btnStopMonitoring.Text = "StopMonitoring";
            this.btnStopMonitoring.UseVisualStyleBackColor = true;
            // 
            // btnResumeMonitoring
            // 
            this.btnResumeMonitoring.Location = new System.Drawing.Point(90, 212);
            this.btnResumeMonitoring.Name = "btnResumeMonitoring";
            this.btnResumeMonitoring.Size = new System.Drawing.Size(135, 43);
            this.btnResumeMonitoring.TabIndex = 22;
            this.btnResumeMonitoring.Text = "ResumeMonitoring";
            this.btnResumeMonitoring.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 520);
            this.Controls.Add(this.tabMetrics);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.tabMetrics.ResumeLayout(false);
            this.tpStorageSettings.ResumeLayout(false);
            this.tpStorageSettings.PerformLayout();
            this.tpMetrics.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpMonitors.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMetrics;
        private System.Windows.Forms.TabPage tpStorageSettings;
        private System.Windows.Forms.TabPage tpMetrics;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label mtName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSaveMetric;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbMetrics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlertRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMetricType;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbStorageType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStoragePassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtStorageUsername;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtStoragePort;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtStorageHost;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtStorageName;
        private System.Windows.Forms.Button btnConnectToStorage;
        private System.Windows.Forms.TabPage tpMonitors;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnResumeMonitoring;
        private System.Windows.Forms.Button btnStopMonitoring;
    }
}