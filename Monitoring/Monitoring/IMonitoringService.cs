using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Monitoring
{
    [ServiceContract] //[ServiceContract(Namespace="http://Firma.Services.Monitoring"]
    public interface IMonitoringService
    {
        [OperationContract]
        bool isAlive();


        [OperationContract]
        MonitoringValues CurrentValues();
    }
}
