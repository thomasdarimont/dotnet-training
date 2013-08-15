using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using Monitoring;


namespace Selfhosting
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceHost host = new ServiceHost(typeof(MonitoringService), 
            //    new Uri[] { new Uri("http://localhost:9500/MonitoringService") });
            ServiceHost host = new ServiceHost(typeof(MonitoringService));
            
            host.Open();
            Console.WriteLine("Service gestartet, Enter um Service zu beenden");

            foreach (Uri uri in host.BaseAddresses)
            {
                Console.WriteLine("address: {0}", uri.ToString());
            }
            Console.ReadLine();
            host.Close();
        }
    }
}
