using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1
{
    [DataContract]
    public class RouteDL
    {
        public static List<Route> myRoutes = new List<Route>();
    }
}