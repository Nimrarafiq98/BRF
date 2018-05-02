using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public bool isvalid(string username, string password)
        {
            bool check = false;
            foreach (myuser u in data.datalist)
            {
                if (u.Username == username && u.Password == password)
                    check = true;
            }




            return check;
        }
        public void registration(string username, string password)
        {
            myuser user = new myuser();
            user.Username = username;
            user.Password = password;
            data.datalist.Add(user);

        }
        public bool reset(string username, string password, string ConfirmPassword)
        {
            bool find = false;
            foreach (myuser u in data.datalist)
            {
                if ((u.Username == username) && (password == ConfirmPassword))
                {
                    u.Password = password;
                    find = true;
                }
            }




            return find;
        }

        public bool update(string busnumber, string routenumber, string newbusnum, string newroutenum)

        {
            bool val = false;
            foreach (Route R in RouteDL.myRoutes)
            {
                if ((R.BusNumber1 == busnumber) && (R.RouteNumber1 == routenumber))
                {
                    R.BusNumber1 = newbusnum;
                    R.RouteNumber1 = newroutenum;
                    val = true;
                }}
            return val;
            
        }

        public bool updatestops(string stopname, string newstopname)
        {
            bool st = false;
            foreach (Stops S in Route.Mystops)
            {
                if (S.StopName1 == stopname)
                {
                    S.StopName1 = newstopname;
                    st = true;
                }
            }
            // stops add
            return st;
        }
        public void addroute(string BusNumber, string RouteNumber)
        {
            Route route = new Route();
            route.BusNumber1 = BusNumber;
            route.RouteNumber1 = RouteNumber;
            RouteDL.myRoutes.Add(route);
        }
        public void addstop(string StopName)
        {
            Stops c = new Stops();
            c.StopName1 = StopName;


            Route.Mystops.Add(c);


        }
        public List<Stops> getstops()
        {
            return Route.Mystops;
        }
        public List<Route> getbusroute()
        {
            return RouteDL.myRoutes;
        }
        public Route getdetail(int ID)
        {
            return RouteDL.myRoutes[ID];
        }
    }
}