using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SqlServerServiceManage
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        private ContextMenu notifyiconMnu;
        private void Form1_Load(object sender, EventArgs e)
        {
            //MSSQLSERVER服务
            ServiceState("MSSQLSERVER", btnMsStart, btnMsStop);
            //MSSQL$SQLEXPRESS服务
            ServiceState("MSSQL$SQLEXPRESS", btnExStart, btnExStop);
            //MySQL56服务
            ServiceState("MySQL56", btnMysqlStart, btnMySqlStop);
            //postgresql-x64-9.2服务
            ServiceState("postgresql-x64-9.2", btnPostgreStart, btnPostgresStop);
        }

        /// <summary>
        /// 开启MSSQLSERVER服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMsStart_Click(object sender, EventArgs e)
        {
            ServiceCommonHelper.StartService("MSSQLSERVER", sender, btnMsStop);
        }

        /// <summary>
        /// 关闭MSSQLSERVER服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMsStop_Click(object sender, EventArgs e)
        {
            ServiceCommonHelper.StopService("MSSQLSERVER", sender, btnMsStart);
        }

        /// <summary>
        /// 开启MSSQL$SQLEXPRESS服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExStart_Click(object sender, EventArgs e)
        {
            ServiceCommonHelper.StartService("MSSQL$SQLEXPRESS", sender, btnExStop);
        }


        /// <summary>
        /// 关闭MSSQL$SQLEXPRESS服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExStop_Click(object sender, EventArgs e)
        {
            ServiceCommonHelper.StopService("MSSQL$SQLEXPRESS", sender, btnExStart);
        }

        /// <summary>
        /// Start MySQL56
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMysqlStart_Click(object sender, EventArgs e)
        {
            ServiceCommonHelper.StartService("MySQL56", sender, btnMySqlStop);
        }

        /// <summary>
        /// Stop MySQL56
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMySqlStop_Click(object sender, EventArgs e)
        {
            ServiceCommonHelper.StopService("MySQL56", sender, btnMysqlStart);
        }

        /// <summary>
        /// Start postgresql-x64-9.2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPostgreStart_Click(object sender, EventArgs e)
        {
            ServiceCommonHelper.StartService("postgresql-x64-9.2", sender, btnPostgresStop);
        }

        /// <summary>
        /// Stop postgresql-x64-9.2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPostgresStop_Click(object sender, EventArgs e)
        {
            ServiceCommonHelper.StopService("postgresql-x64-9.2", sender, btnPostgreStart);
        }

        /// <summary>
        /// 获取服务的状态
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="startSender"></param>
        /// <param name="stopSender"></param>
        private void ServiceState(string serviceName, object startSender, object stopSender)
        {
            ServiceController[] services = ServiceController.GetServices();
            Button btnStart = startSender as Button;
            Button btnStop = stopSender as Button;
            if (btnStart != null && btnStop != null)
            {
                ThreadPool.QueueUserWorkItem(a =>
                {
                    foreach (ServiceController s in services.Where<ServiceController>(p => p.ServiceName == serviceName))
                    {
                        //服务存在
                        //判断服务是否开启
                        if (s.Status == ServiceControllerStatus.Stopped ||
                            s.Status == ServiceControllerStatus.StopPending)
                        {
                            //如果服务器已经停止

                            btnStart.Enabled = true;
                        }
                        else
                        {

                            btnStop.Enabled = true;
                        }
                    }
                });
            }
        }

        #region 最小化到任务栏
        /// <summary>
        /// 最小化到任务栏
        /// </summary>
        private void Initializenotifyicon()
        {
            //定义一个MenuItem数组，并把此数组同时赋值给ContextMenu对象 
            MenuItem[] mnuItms = new MenuItem[3];
            mnuItms[0] = new MenuItem();
            mnuItms[0].Text = "显示窗口";
            mnuItms[0].Click += new System.EventHandler(this.notifyIcon1_showfrom);

            mnuItms[1] = new MenuItem("-");

            mnuItms[2] = new MenuItem();
            mnuItms[2].Text = "退出系统";
            mnuItms[2].Click += new System.EventHandler(this.ExitSelect);
            mnuItms[2].DefaultItem = true;

            notifyiconMnu = new ContextMenu(mnuItms);
            notifyIcon1.ContextMenu = notifyiconMnu;
            //为托盘程序加入设定好的ContextMenu对象 
        }


        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        public void notifyIcon1_showfrom(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        public void ExitSelect(object sender, System.EventArgs e)
        {
            //隐藏托盘程序中的图标 
            notifyIcon1.Visible = false;
            //关闭系统 
            this.Close();
            this.Dispose(true);
        }

        #endregion
        private void Form_main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) //判断是否最小化
            {
                notifyIcon1.Visible = true;
                this.Hide();
                this.ShowInTaskbar = false;

                Initializenotifyicon();
            }
        }

        /// <summary>
        /// 点击我博客园的地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Change the color of the link text by setting LinkVisited 
                // to true.
                linkLabel1.LinkVisited = true;
                //Call the Process.Start method to open the default browser 
                //with a URL:
                System.Diagnostics.Process.Start("http://www.cnblogs.com/haoxilu");

            }
            catch (Exception)
            {
                System.Diagnostics.Process.Start("http://www.cnblogs.com/haoxilu");
            }
           
        }

    }
}
