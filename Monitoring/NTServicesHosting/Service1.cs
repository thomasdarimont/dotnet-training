using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

using System.ServiceModel;
using Monitoring;


namespace NTServicesHosting
{
    public partial class Service1 : ServiceBase
    {
        private ServiceHost host;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (host == null)
            {
                host = new ServiceHost(typeof(MonitoringService));
            }

            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null)
            {
                host.Close();
            }
        }
    }
}
