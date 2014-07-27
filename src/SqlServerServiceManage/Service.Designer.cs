namespace SqlServerServiceManage
{
    partial class Service
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.btnMsStart = new System.Windows.Forms.Button();
            this.btnMsStop = new System.Windows.Forms.Button();
            this.btnExStart = new System.Windows.Forms.Button();
            this.btnExStop = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPostgreStart = new System.Windows.Forms.Button();
            this.btnPostgresStop = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMysqlStart = new System.Windows.Forms.Button();
            this.btnMySqlStop = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMsStart
            // 
            this.btnMsStart.Enabled = false;
            this.btnMsStart.Location = new System.Drawing.Point(22, 46);
            this.btnMsStart.Name = "btnMsStart";
            this.btnMsStart.Size = new System.Drawing.Size(89, 23);
            this.btnMsStart.TabIndex = 0;
            this.btnMsStart.Text = "Start";
            this.btnMsStart.UseVisualStyleBackColor = true;
            this.btnMsStart.Click += new System.EventHandler(this.btnMsStart_Click);
            // 
            // btnMsStop
            // 
            this.btnMsStop.Enabled = false;
            this.btnMsStop.Location = new System.Drawing.Point(141, 46);
            this.btnMsStop.Name = "btnMsStop";
            this.btnMsStop.Size = new System.Drawing.Size(94, 23);
            this.btnMsStop.TabIndex = 1;
            this.btnMsStop.Text = "Stop";
            this.btnMsStop.UseVisualStyleBackColor = true;
            this.btnMsStop.Click += new System.EventHandler(this.btnMsStop_Click);
            // 
            // btnExStart
            // 
            this.btnExStart.Enabled = false;
            this.btnExStart.Location = new System.Drawing.Point(21, 46);
            this.btnExStart.Name = "btnExStart";
            this.btnExStart.Size = new System.Drawing.Size(89, 23);
            this.btnExStart.TabIndex = 2;
            this.btnExStart.Text = "Start";
            this.btnExStart.UseVisualStyleBackColor = true;
            this.btnExStart.Click += new System.EventHandler(this.btnExStart_Click);
            // 
            // btnExStop
            // 
            this.btnExStop.Enabled = false;
            this.btnExStop.Location = new System.Drawing.Point(140, 46);
            this.btnExStop.Name = "btnExStop";
            this.btnExStop.Size = new System.Drawing.Size(94, 23);
            this.btnExStop.TabIndex = 3;
            this.btnExStop.Text = "Stop";
            this.btnExStop.UseVisualStyleBackColor = true;
            this.btnExStop.Click += new System.EventHandler(this.btnExStop_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SqlServerServiceManage(2.0)  By 郝喜路";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMsStart);
            this.groupBox1.Controls.Add(this.btnMsStop);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server (MSSQLSERVER)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExStart);
            this.groupBox2.Controls.Add(this.btnExStop);
            this.groupBox2.Location = new System.Drawing.Point(308, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL Server (SQLEXPRESS)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPostgreStart);
            this.groupBox3.Controls.Add(this.btnPostgresStop);
            this.groupBox3.Location = new System.Drawing.Point(310, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PostgreSQL(postgresql-x64-9.2)";
            // 
            // btnPostgreStart
            // 
            this.btnPostgreStart.Enabled = false;
            this.btnPostgreStart.Location = new System.Drawing.Point(21, 46);
            this.btnPostgreStart.Name = "btnPostgreStart";
            this.btnPostgreStart.Size = new System.Drawing.Size(89, 23);
            this.btnPostgreStart.TabIndex = 2;
            this.btnPostgreStart.Text = "Start";
            this.btnPostgreStart.UseVisualStyleBackColor = true;
            this.btnPostgreStart.Click += new System.EventHandler(this.btnPostgreStart_Click);
            // 
            // btnPostgresStop
            // 
            this.btnPostgresStop.Enabled = false;
            this.btnPostgresStop.Location = new System.Drawing.Point(140, 46);
            this.btnPostgresStop.Name = "btnPostgresStop";
            this.btnPostgresStop.Size = new System.Drawing.Size(94, 23);
            this.btnPostgresStop.TabIndex = 3;
            this.btnPostgresStop.Text = "Stop";
            this.btnPostgresStop.UseVisualStyleBackColor = true;
            this.btnPostgresStop.Click += new System.EventHandler(this.btnPostgresStop_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMysqlStart);
            this.groupBox4.Controls.Add(this.btnMySqlStop);
            this.groupBox4.Location = new System.Drawing.Point(14, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MySql(MySQL56)";
            // 
            // btnMysqlStart
            // 
            this.btnMysqlStart.Enabled = false;
            this.btnMysqlStart.Location = new System.Drawing.Point(22, 46);
            this.btnMysqlStart.Name = "btnMysqlStart";
            this.btnMysqlStart.Size = new System.Drawing.Size(89, 23);
            this.btnMysqlStart.TabIndex = 0;
            this.btnMysqlStart.Text = "Start";
            this.btnMysqlStart.UseVisualStyleBackColor = true;
            this.btnMysqlStart.Click += new System.EventHandler(this.btnMysqlStart_Click);
            // 
            // btnMySqlStop
            // 
            this.btnMySqlStop.Enabled = false;
            this.btnMySqlStop.Location = new System.Drawing.Point(141, 46);
            this.btnMySqlStop.Name = "btnMySqlStop";
            this.btnMySqlStop.Size = new System.Drawing.Size(94, 23);
            this.btnMySqlStop.TabIndex = 1;
            this.btnMySqlStop.Text = "Stop";
            this.btnMySqlStop.UseVisualStyleBackColor = true;
            this.btnMySqlStop.Click += new System.EventHandler(this.btnMySqlStop_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(289, 243);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(185, 12);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.cnblogs.com/haoxilu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Copyright © 郝喜路2014";
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceManage(3.0)  By 郝喜路";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form_main_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMsStart;
        private System.Windows.Forms.Button btnMsStop;
        private System.Windows.Forms.Button btnExStart;
        private System.Windows.Forms.Button btnExStop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPostgreStart;
        private System.Windows.Forms.Button btnPostgresStop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMysqlStart;
        private System.Windows.Forms.Button btnMySqlStop;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

