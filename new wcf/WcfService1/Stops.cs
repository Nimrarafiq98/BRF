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

    }
}