using System.Linq;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

namespace SqlServerServiceManage
{
    public class ServiceCommonHelper
    {

        private static readonly ServiceController Service = GetServiceController();
        /// <summary>
        /// 获取ServiceController的对象
        /// </summary>
        /// <returns></returns>
        private static ServiceController GetServiceController()
        {
            return new ServiceController();
        }

        /// <summary>
        /// 开启服务
        /// </summary>
        /// <param name="serviceName">服务名称</param>
        /// <param name="sender">开启的控件名称</param>
        /// /// <param name="stop">关闭的控件名称</param>
        public static void StartService(string serviceName, object sender, object stop)
        {
            Button btnStart = sender as Button;
            Button btnStop = stop as Button;
            MyLock myLock = new MyLock();
            if (btnStart != null && btnStop != null)
            {
                btnStart.Text = "Starting...";
                btnStart.Enabled = false;
                //开启MSSQLSERVER服务
                ThreadPool.QueueUserWorkItem(new WaitCallback(a =>
                {
                    lock (myLock)
                    {
                        Thread.Sleep(3000);
                        Service.ServiceName = serviceName;
                        Service.Start();
                        while (true)
                        {
                            if (ServiceState(serviceName))
                            {
                                btnStart.Enabled = true;
                                btnStart.Text = "Start";
                                btnStart.Enabled = false;
                                btnStop.Enabled = true;
                                break;
                            }
                        }
                    }
                }));
            }
        }

        /// <summary>
        /// 关闭服务
        /// </summary>
        /// <param name="serviceName">服务名称</param>
        /// <param name="sender">关闭服务按钮</param>
        /// <param name="start">开启服务按钮</param>
        public static void StopService(string serviceName, object sender, object start)
        {
            Button btnStop = sender as Button;
            Button btnStart = start as Button;
            MyLock myLock = new MyLock();
            if (btnStop != null && btnStart != null)
            {
                btnStop.Text = "Stopping...";
                btnStop.Enabled = false;
                //关闭MSSQLSERVER服务
                ThreadPool.QueueUserWorkItem(a =>
                {
                    lock (myLock)
                    {
                        Thread.Sleep(3000);
                        Service.ServiceName = serviceName;
                        Service.Stop();

                        while (true)
                        {
                            if (ServiceState(serviceName) == false)
                            {
                                btnStop.Enabled = true;
                                btnStop.Text = "Stop";
                                btnStop.Enabled = false;
                                btnStart.Enabled = true;
                                break;
                            }
                        }
                    }
                });
            }
        }

        /// <summary>
        /// 判断指定系统服务是否开启
        /// </summary>
        /// <param name="serviceName"></param>
        /// <returns>开启为true，未开启为false</returns>
        private static bool ServiceState(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            bool b = true;
            foreach (ServiceController s in services.Where < ServiceController>(p => p.ServiceName == serviceName))
            {
                    //判断服务是否开启
                if (s.Status == ServiceControllerStatus.Stopped ||
                    s.Status == ServiceControllerStatus.StopPending)
                {
                    //如果服务器已经停止

                    b = false;
                    break;
                }
            }
            return b;
        }
    }

    class MyLock
    {

    }
}