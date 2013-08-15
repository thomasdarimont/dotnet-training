using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Monitoring
{
    [DataContract]
    public class MonitoringValues
    {
        [DataMember]
        public string Maschinenstatus;
        [DataMember]
        public int Gutmengen;
        [DataMember]
        public int Ausschussmengen;

        //...
    }
}