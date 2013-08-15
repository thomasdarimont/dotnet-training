using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MonitoringClient.refMonitoring;

namespace MonitoringClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MonitoringServiceClient proxy = new MonitoringServiceClient(
                //"netTcpEndpoint"
                "httpEndpoint"
                );

            proxy.Open();
            while (true)
            {

                Thread.Sleep(TimeSpan.FromSeconds(1));

                
                MonitoringValues values = proxy.CurrentValues();
                bool isAlive = proxy.isAlive();
                

                Console.WriteLine("Maschinenstatus: {0}\nGutmengen: {1}\nAusschussmengen: {2}",
                    values.Maschinenstatus, values.Gutmengen, values.Ausschussmengen);
//                Console.ReadLine();

            }
            proxy.Close();
        }
    }
}
