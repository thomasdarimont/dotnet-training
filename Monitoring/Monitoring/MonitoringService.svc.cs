using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Monitoring
{
    public class MonitoringService : IMonitoringService
    {
        public bool isAlive()
        {
            return true;
        }


        public MonitoringValues CurrentValues()
        {
            return new MonitoringValues()
                {
                    Maschinenstatus = "OK",
                    Gutmengen = 12 + (int)(new Random().NextDouble()*50),
                    Ausschussmengen = 2 + (int)(new Random().NextDouble() * 10)
                };
        }
    }
}
