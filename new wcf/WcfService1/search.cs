using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Web;

namespace WcfService1
     
{
     [DataContract]
    public class search
    {
        public static List<Route> searchr = new List<Route>();
        public static List<Route> picklist = new List<Route>();
        public static List<Route> shortest = new List<Route>();
        
    }
}