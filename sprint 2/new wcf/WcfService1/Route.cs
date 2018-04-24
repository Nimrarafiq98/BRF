using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Route
    {
        private string BusNumber;

        public string BusNumber1
        {
            get { return BusNumber; }
            set { BusNumber = value; }
        }
        private string RouteNumber;

        public string RouteNumber1
        {
            get { return RouteNumber; }
            set { RouteNumber = value; }
        }
        private static List<Stops> mystops = new List<Stops>();

        public static List<Stops> Mystops
        {
            get { return mystops; }
            set { mystops = value; }
        }

    }
}