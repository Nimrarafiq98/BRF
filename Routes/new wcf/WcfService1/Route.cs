using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1
{
    [DataContract]
    public class Route
    {

        private string BusNumber;
        [DataMember]
        public string BusNumber1
        {
            get { return BusNumber; }
            set { BusNumber = value; }
        }
        private string RouteNumber;
        [DataMember]
        public string RouteNumber1
        {
            get { return RouteNumber; }
            set { RouteNumber = value; }
        }

        private static List<Stops> mystops = new List<Stops>();
        [DataMember]
        public static List<Stops> Mystops
        {
            get { return mystops; }
            set { mystops = value; }
        }

    }
}