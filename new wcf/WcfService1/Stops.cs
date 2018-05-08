using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1
{
    [DataContract]
    public class Stops
    {
        private string StopName;
        [DataMember]
        public string StopName1
        {
            get { return StopName; }
            set { StopName = value; }
        }
        private int Longitude;
        [DataMember]
        public int Longitude1
        {
            get { return Longitude; }
            set { Longitude = value; }
        }
        private int latitude;
        [DataMember]
        public int Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

    }
}