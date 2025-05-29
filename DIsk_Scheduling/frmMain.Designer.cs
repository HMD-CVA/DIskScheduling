namespace DIsk_Scheduling
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Setting = new System.Windows.Forms.TabPage();
            this.gb_Algorithm = new System.Windows.Forms.GroupBox();
            this.btn_clook = new System.Windows.Forms.RadioButton();
            this.btn_Look = new System.Windows.Forms.RadioButton();
            this.btn_FCFS = new System.Windows.Forms.RadioButton();
            this.btn_SSTF = new System.Windows.Forms.RadioButton();
            this.btn_cscan = new System.Windows.Forms.RadioButton();
            this.btn_Scan = new System.Windows.Forms.RadioButton();
            this.txt_HeadValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_FillRandom = new System.Windows.Forms.Button();
            this.tabPage_Control = new System.Windows.Forms.TabPage();
            this.HeadValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.pn_STvaRP = new System.Windows.Forms.Panel();
            this.panel_Report = new System.Windows.Forms.Panel();
            this.gb_Report = new System.Windows.Forms.GroupBox();
            this.btn_ToRight = new System.Windows.Forms.RadioButton();
            this.btn_ToLeft = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SeekCnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.panel_Graph = new System.Windows.Forms.Panel();
            this.gb_Graph = new System.Windows.Forms.GroupBox();
            this.lb_Time = new System.Windows.Forms.Label();
            this.pannel_TS = new System.Windows.Forms.Panel();
            this.pn_Full = new System.Windows.Forms.Panel();
            this.pn_FullGraph = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage_Setting.SuspendLayout();
            this.gb_Algorithm.SuspendLayout();
            this.tabPage_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadValue)).BeginInit();
            this.pn_STvaRP.SuspendLayout();
            this.panel_Report.SuspendLayout();
            this.gb_Report.SuspendLayout();
            this.panel_Setting.SuspendLayout();
            this.gb_Graph.SuspendLayout();
            this.pannel_TS.SuspendLayout();
            this.pn_Full.SuspendLayout();
            this.pn_FullGraph.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(2539, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Image = global::DIsk_Scheduling.Properties.Resources.information;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Image = global::DIsk_Scheduling.Properties.Resources.aboutUS;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(171, 28);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::DIsk_Scheduling.Properties.Resources.guide;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(171, 28);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage_Setting);
            this.TabControl.Controls.Add(this.tabPage_Control);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1145, 386);
            this.TabControl.TabIndex = 1;
            // 
            // tabPage_Setting
            // 
            this.tabPage_Setting.Controls.Add(this.gb_Algorithm);
            this.tabPage_Setting.Controls.Add(this.txt_HeadValue);
            this.tabPage_Setting.Controls.Add(this.button1);
            this.tabPage_Setting.Controls.Add(this.label2);
            this.tabPage_Setting.Controls.Add(this.txt_Input);
            this.tabPage_Setting.Controls.Add(this.label1);
            this.tabPage_Setting.Controls.Add(this.btn_Clear);
            this.tabPage_Setting.Controls.Add(this.btn_FillRandom);
            this.tabPage_Setting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Setting.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Setting.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_Setting.Name = "tabPage_Setting";
            this.tabPage_Setting.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Setting.Size = new System.Drawing.Size(1137, 342);
            this.tabPage_Setting.TabIndex = 0;
            this.tabPage_Setting.Text = "Setting";
            this.tabPage_Setting.UseVisualStyleBackColor = true;
            // 
            // gb_Algorithm
            // 
            this.gb_Algorithm.AutoSize = true;
            this.gb_Algorithm.Controls.Add(this.btn_clook);
            this.gb_Algorithm.Controls.Add(this.btn_Look);
            this.gb_Algorithm.Controls.Add(this.btn_FCFS);
            this.gb_Algorithm.Controls.Add(this.btn_SSTF);
            this.gb_Algorithm.Controls.Add(this.btn_cscan);
            this.gb_Algorithm.Controls.Add(this.btn_Scan);
            this.gb_Algorithm.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_Algorithm.Location = new System.Drawing.Point(971, 4);
            this.gb_Algorithm.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Algorithm.Name = "gb_Algorithm";
            this.gb_Algorithm.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Algorithm.Size = new System.Drawing.Size(162, 334);
            this.gb_Algorithm.TabIndex = 13;
            this.gb_Algorithm.TabStop = false;
            this.gb_Algorithm.Text = "Algorithm";
            // 
            // btn_clook
            // 
            this.btn_clook.AutoSize = true;
            this.btn_clook.Location = new System.Drawing.Point(15, 229);
            this.btn_clook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clook.Name = "btn_clook";
            this.btn_clook.Size = new System.Drawing.Size(139, 36);
            this.btn_clook.TabIndex = 9;
            this.btn_clook.TabStop = true;
            this.btn_clook.Text = "C-LOOK";
            this.btn_clook.UseVisualStyleBackColor = true;
            this.btn_clook.CheckedChanged += new System.EventHandler(this.btn_Scan_CheckedChanged);
            // 
            // btn_Look
            // 
            this.btn_Look.AutoSize = true;
            this.btn_Look.Location = new System.Drawing.Point(15, 273);
            this.btn_Look.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Look.Name = "btn_Look";
            this.btn_Look.Size = new System.Drawing.Size(110, 36);
            this.btn_Look.TabIndex = 12;
            this.btn_Look.TabStop = true;
            this.btn_Look.Text = "LOOK";
            this.btn_Look.UseVisualStyleBackColor = true;
            this.btn_Look.CheckedChanged += new System.EventHandler(this.btn_Scan_CheckedChanged);
            // 
            // btn_FCFS
            // 
            this.btn_FCFS.AutoSize = true;
            this.btn_FCFS.Location = new System.Drawing.Point(15, 52);
            this.btn_FCFS.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FCFS.Name = "btn_FCFS";
            this.btn_FCFS.Size = new System.Drawing.Size(107, 36);
            this.btn_FCFS.TabIndex = 4;
            this.btn_FCFS.TabStop = true;
            this.btn_FCFS.Text = "FCFS";
            this.btn_FCFS.UseVisualStyleBackColor = true;
            // 
            // btn_SSTF
            // 
            this.btn_SSTF.AutoSize = true;
            this.btn_SSTF.Location = new System.Drawing.Point(15, 96);
            this.btn_SSTF.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SSTF.Name = "btn_SSTF";
            this.btn_SSTF.Size = new System.Drawing.Size(104, 36);
            this.btn_SSTF.TabIndex = 6;
            this.btn_SSTF.TabStop = true;
            this.btn_SSTF.Text = "SSTF";
            this.btn_SSTF.UseVisualStyleBackColor = true;
            // 
            // btn_cscan
            // 
            this.btn_cscan.AutoSize = true;
            this.btn_cscan.Location = new System.Drawing.Point(15, 185);
            this.btn_cscan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cscan.Name = "btn_cscan";
            this.btn_cscan.Size = new System.Drawing.Size(139, 36);
            this.btn_cscan.TabIndex = 8;
            this.btn_cscan.TabStop = true;
            this.btn_cscan.Text = "C-SCAN";
            this.btn_cscan.UseVisualStyleBackColor = true;
            this.btn_cscan.CheckedChanged += new System.EventHandler(this.btn_Scan_CheckedChanged);
            // 
            // btn_Scan
            // 
            this.btn_Scan.AutoSize = true;
            this.btn_Scan.Location = new System.Drawing.Point(15, 140);
            this.btn_Scan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(110, 36);
            this.btn_Scan.TabIndex = 7;
            this.btn_Scan.TabStop = true;
            this.btn_Scan.Text = "SCAN";
            this.btn_Scan.UseVisualStyleBackColor = true;
            this.btn_Scan.CheckedChanged += new System.EventHandler(this.btn_Scan_CheckedChanged);
            // 
            // txt_HeadValue
            // 
            this.txt_HeadValue.Location = new System.Drawing.Point(225, 65);
            this.txt_HeadValue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HeadValue.Multiline = true;
            this.txt_HeadValue.Name = "txt_HeadValue";
            this.txt_HeadValue.Size = new System.Drawing.Size(729, 69);
            this.txt_HeadValue.TabIndex = 11;
            this.txt_HeadValue.TextChanged += new System.EventHandler(this.txt_HeadValue_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Head Position";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(177, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(783, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please enter numbers from 0 to 199, separated by commas (\',\').";
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(225, 145);
            this.txt_Input.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Input.Multiline = true;
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(729, 149);
            this.txt_Input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "DISK REQUEST";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(13, 225);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(204, 70);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_FillRandom
            // 
            this.btn_FillRandom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FillRandom.Location = new System.Drawing.Point(13, 145);
            this.btn_FillRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FillRandom.Name = "btn_FillRandom";
            this.btn_FillRandom.Size = new System.Drawing.Size(204, 70);
            this.btn_FillRandom.TabIndex = 0;
            this.btn_FillRandom.Text = "Fill Random";
            this.btn_FillRandom.UseVisualStyleBackColor = true;
            this.btn_FillRandom.Click += new System.EventHandler(this.btn_FillRandom_Click);
            // 
            // tabPage_Control
            // 
            this.tabPage_Control.Controls.Add(this.HeadValue);
            this.tabPage_Control.Controls.Add(this.label5);
            this.tabPage_Control.Controls.Add(this.btnUndo);
            this.tabPage_Control.Controls.Add(this.btnRedo);
            this.tabPage_Control.Controls.Add(this.btnPause);
            this.tabPage_Control.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Control.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_Control.Name = "tabPage_Control";
            this.tabPage_Control.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Control.Size = new System.Drawing.Size(1137, 342);
            this.tabPage_Control.TabIndex = 1;
            this.tabPage_Control.Text = "Control";
            this.tabPage_Control.UseVisualStyleBackColor = true;
            // 
            // HeadValue
            // 
            this.HeadValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadValue.Location = new System.Drawing.Point(665, 44);
            this.HeadValue.Margin = new System.Windows.Forms.Padding(4);
            this.HeadValue.Name = "HeadValue";
            this.HeadValue.Size = new System.Drawing.Size(160, 46);
            this.HeadValue.TabIndex = 3;
            this.HeadValue.ValueChanged += new System.EventHandler(this.HeadValue_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Initial Head Position:";
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo.Enabled = false;
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Image = global::DIsk_Scheduling.Properties.Resources.undo;
            this.btnUndo.Location = new System.Drawing.Point(170, 163);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(150, 150);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedo.Enabled = false;
            this.btnRedo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.Image = global::DIsk_Scheduling.Properties.Resources.redo;
            this.btnRedo.Location = new System.Drawing.Point(816, 163);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(150, 150);
            this.btnRedo.TabIndex = 3;
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Image = global::DIsk_Scheduling.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(488, 163);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(150, 150);
            this.btnPause.TabIndex = 3;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // pn_STvaRP
            // 
            this.pn_STvaRP.Controls.Add(this.panel_Report);
            this.pn_STvaRP.Controls.Add(this.panel_Setting);
            this.pn_STvaRP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_STvaRP.Location = new System.Drawing.Point(0, 0);
            this.pn_STvaRP.Margin = new System.Windows.Forms.Padding(4);
            this.pn_STvaRP.Name = "pn_STvaRP";
            this.pn_STvaRP.Size = new System.Drawing.Size(2539, 388);
            this.pn_STvaRP.TabIndex = 2;
            // 
            // panel_Report
            // 
            this.panel_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Report.Controls.Add(this.gb_Report);
            this.panel_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Report.Location = new System.Drawing.Point(1147, 0);
            this.panel_Report.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Report.Name = "panel_Report";
            this.panel_Report.Size = new System.Drawing.Size(1392, 388);
            this.panel_Report.TabIndex = 3;
            // 
            // gb_Report
            // 
            this.gb_Report.Controls.Add(this.btn_ToRight);
            this.gb_Report.Controls.Add(this.btn_ToLeft);
            this.gb_Report.Controls.Add(this.btn_Reset);
            this.gb_Report.Controls.Add(this.btn_Start);
            this.gb_Report.Controls.Add(this.label4);
            this.gb_Report.Controls.Add(this.txt_SeekCnt);
            this.gb_Report.Controls.Add(this.label3);
            this.gb_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Report.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Report.Location = new System.Drawing.Point(0, 0);
            this.gb_Report.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Report.Name = "gb_Report";
            this.gb_Report.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Report.Size = new System.Drawing.Size(1390, 386);
            this.gb_Report.TabIndex = 0;
            this.gb_Report.TabStop = false;
            this.gb_Report.Text = "REPORT";
            // 
            // btn_ToRight
            // 
            this.btn_ToRight.AutoSize = true;
            this.btn_ToRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ToRight.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ToRight.Location = new System.Drawing.Point(855, 322);
            this.btn_ToRight.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ToRight.Name = "btn_ToRight";
            this.btn_ToRight.Size = new System.Drawing.Size(278, 41);
            this.btn_ToRight.TabIndex = 7;
            this.btn_ToRight.TabStop = true;
            this.btn_ToRight.Text = "Right Head Position";
            this.btn_ToRight.UseVisualStyleBackColor = true;
            // 
            // btn_ToLeft
            // 
            this.btn_ToLeft.AutoSize = true;
            this.btn_ToLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ToLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ToLeft.Location = new System.Drawing.Point(240, 322);
            this.btn_ToLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ToLeft.Name = "btn_ToLeft";
            this.btn_ToLeft.Size = new System.Drawing.Size(259, 41);
            this.btn_ToLeft.TabIndex = 6;
            this.btn_ToLeft.TabStop = true;
            this.btn_ToLeft.Text = "Left Head Position";
            this.btn_ToLeft.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(761, 143);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(235, 82);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(395, 143);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(235, 82);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1256, 67);
            this.label4.TabIndex = 2;
            this.label4.Text = "ALGORITHM ILLUSTRATION FOR DISK SCHEDULING";
            // 
            // txt_SeekCnt
            // 
            this.txt_SeekCnt.Location = new System.Drawing.Point(597, 251);
            this.txt_SeekCnt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SeekCnt.Name = "txt_SeekCnt";
            this.txt_SeekCnt.ReadOnly = true;
            this.txt_SeekCnt.Size = new System.Drawing.Size(420, 42);
            this.txt_SeekCnt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "SEEK COUNT:";
            // 
            // panel_Setting
            // 
            this.panel_Setting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Setting.Controls.Add(this.TabControl);
            this.panel_Setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Setting.Location = new System.Drawing.Point(0, 0);
            this.panel_Setting.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(1147, 388);
            this.panel_Setting.TabIndex = 2;
            // 
            // panel_Graph
            // 
            this.panel_Graph.AutoScroll = true;
            this.panel_Graph.AutoSize = true;
            this.panel_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Graph.Location = new System.Drawing.Point(7, 41);
            this.panel_Graph.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Graph.Name = "panel_Graph";
            this.panel_Graph.Size = new System.Drawing.Size(2511, 779);
            this.panel_Graph.TabIndex = 3;
            this.panel_Graph.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Graph_Paint);
            // 
            // gb_Graph
            // 
            this.gb_Graph.Controls.Add(this.panel_Graph);
            this.gb_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Graph.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Graph.Location = new System.Drawing.Point(7, 6);
            this.gb_Graph.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Graph.Name = "gb_Graph";
            this.gb_Graph.Padding = new System.Windows.Forms.Padding(7, 6, 7, 30);
            this.gb_Graph.Size = new System.Drawing.Size(2525, 850);
            this.gb_Graph.TabIndex = 0;
            this.gb_Graph.TabStop = false;
            this.gb_Graph.Text = "GRAPH";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.BackColor = System.Drawing.SystemColors.Window;
            this.lb_Time.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_Time.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(2469, 0);
            this.lb_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(70, 32);
            this.lb_Time.TabIndex = 3;
            this.lb_Time.Text = "Time";
            // 
            // pannel_TS
            // 
            this.pannel_TS.AutoSize = true;
            this.pannel_TS.Controls.Add(this.lb_Time);
            this.pannel_TS.Controls.Add(this.menuStrip1);
            this.pannel_TS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pannel_TS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannel_TS.Location = new System.Drawing.Point(0, 0);
            this.pannel_TS.Margin = new System.Windows.Forms.Padding(4);
            this.pannel_TS.Name = "pannel_TS";
            this.pannel_TS.Size = new System.Drawing.Size(2539, 31);
            this.pannel_TS.TabIndex = 3;
            // 
            // pn_Full
            // 
            this.pn_Full.Controls.Add(this.pn_FullGraph);
            this.pn_Full.Controls.Add(this.pn_STvaRP);
            this.pn_Full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Full.Location = new System.Drawing.Point(0, 31);
            this.pn_Full.Margin = new System.Windows.Forms.Padding(4);
            this.pn_Full.Name = "pn_Full";
            this.pn_Full.Size = new System.Drawing.Size(2539, 1250);
            this.pn_Full.TabIndex = 4;
            // 
            // pn_FullGraph
            // 
            this.pn_FullGraph.Controls.Add(this.gb_Graph);
            this.pn_FullGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_FullGraph.Location = new System.Drawing.Point(0, 388);
            this.pn_FullGraph.Margin = new System.Windows.Forms.Padding(4);
            this.pn_FullGraph.Name = "pn_FullGraph";
            this.pn_FullGraph.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pn_FullGraph.Size = new System.Drawing.Size(2539, 862);
            this.pn_FullGraph.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pn_Full);
            this.panel1.Controls.Add(this.pannel_TS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2539, 1281);
            this.panel1.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2539, 1281);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulator Disk Scheduling";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage_Setting.ResumeLayout(false);
            this.tabPage_Setting.PerformLayout();
            this.gb_Algorithm.ResumeLayout(false);
            this.gb_Algorithm.PerformLayout();
            this.tabPage_Control.ResumeLayout(false);
            this.tabPage_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadValue)).EndInit();
            this.pn_STvaRP.ResumeLayout(false);
            this.panel_Report.ResumeLayout(false);
            this.gb_Report.ResumeLayout(false);
            this.gb_Report.PerformLayout();
            this.panel_Setting.ResumeLayout(false);
            this.gb_Graph.ResumeLayout(false);
            this.gb_Graph.PerformLayout();
            this.pannel_TS.ResumeLayout(false);
            this.pannel_TS.PerformLayout();
            this.pn_Full.ResumeLayout(false);
            this.pn_FullGraph.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage_Setting;
        private System.Windows.Forms.TabPage tabPage_Control;
        private System.Windows.Forms.Panel pn_STvaRP;
        private System.Windows.Forms.Panel panel_Graph;
        private System.Windows.Forms.Panel panel_Report;
        private System.Windows.Forms.Panel panel_Setting;
        private System.Windows.Forms.GroupBox gb_Graph;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox gb_Report;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_FillRandom;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btn_FCFS;
        private System.Windows.Forms.RadioButton btn_clook;
        private System.Windows.Forms.RadioButton btn_cscan;
        private System.Windows.Forms.RadioButton btn_Scan;
        private System.Windows.Forms.RadioButton btn_SSTF;
        private System.Windows.Forms.TextBox txt_SeekCnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown HeadValue;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.TextBox txt_HeadValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton btn_Look;
        private System.Windows.Forms.RadioButton btn_ToRight;
        private System.Windows.Forms.RadioButton btn_ToLeft;
        private System.Windows.Forms.Panel pannel_TS;
        private System.Windows.Forms.GroupBox gb_Algorithm;
        private System.Windows.Forms.Panel pn_Full;
        private System.Windows.Forms.Panel pn_FullGraph;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnPause;
    }
}

