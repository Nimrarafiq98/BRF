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
        public bool isvalid(string username, string password,string Type)
        {
            bool check = false;
            foreach (myuser u in data.datalist)
            {
                if (u.Username == username && u.Password == password)
                    check = true;
            }




            return check;
        }
        public bool registration(string username, string password,string type)
        {
            bool check = true;
            myuser user = new myuser();
            if ((username == "") && (password == "")&&(type==""))
            {
                check = false;
            }
            else
            {
                user.Username = username;
                user.Password = password;
                user.Type = type;
                data.datalist.Add(user);
              
            }
            return check;
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
                }
            }
            return val;

        }

        public bool updatestops(string busnumber,string stopname, string newstopname)
        {
            bool val = false;
            foreach (Route R in RouteDL.myRoutes)
            {
                if ((R.BusNumber1 == busnumber))
                {
                    foreach (Stops S in R.Mystops)
                    {
                        if (S.StopName1 == stopname)
                        {
                            S.StopName1 = newstopname;
                            val = true;
                        }
                    }
                }
            }
            return val;

           
        }
        public bool addroute(string BusNumber, string RouteNumber)
        {
            bool check = true;
            if ((BusNumber == "") && (RouteNumber == "")) { check = false; }
            else
            {
                Route route = new Route();
                route.BusNumber1 = BusNumber;
                route.RouteNumber1 = RouteNumber;
                RouteDL.myRoutes.Add(route);
            }
            return check;
        }
        public bool addstop(string busnumber,string StopName,string longitude,string latitude)
        {
            bool check = true;
            if ((StopName == "") && (latitude == "") && (longitude == ""))
            { check = false; }
            else
            {
                bool val = false;
                foreach (Route R in RouteDL.myRoutes)
                {
                    if ((R.BusNumber1 == busnumber))
                    {
                        Stops c = new Stops();
                        c.StopName1 = StopName;
                        c.Longitude1 = int.Parse(longitude);
                        c.Latitude = int.Parse(latitude);
                        R.Mystops.Add(c);
                        val = true;
                    }
                }
                return val;

            }
            return check;
        }
        public bool searchpick(string pickup)
        {
            bool pick= false;
            foreach (Route R in RouteDL.myRoutes)
            {
                foreach (Stops S in R.Mystops)
                {
                    if (S.StopName1 == pickup)
                    {
                        search.picklist.Add(R);
                         pick=true;
                    }
                }
               
            }
            return pick;
        }

        public bool searchdown(string dropdown, string pickup)
        {
            bool down = false;
            if (searchpick(pickup))
            {
                
                foreach (Route R in search.picklist)
                {
                    foreach (Stops S in R.Mystops)
                    {
                        if (S.StopName1 == dropdown)
                        {
                            search.searchr.Add(R);
                            down = true;
                        }
                    }
                }
                
            }
            return down;
        }
        

        public int distance(string pickup,string dropdown)
        {
            foreach (Route R in search.searchr)
            {
               
                int x1 =0 ;
                int y1 =0;
                int x2 =0;
                int y2 =0;


                foreach (Stops S in R.Mystops)
                {
                    if (S.StopName1 == pickup)
                    {
                        x1 = S.Longitude1;
                        y1 = S.Latitude;
                    }
                }
                foreach (Stops s in R.Mystops)
                {
                    if (s.StopName1 == dropdown)
                    {
                    
                        x2 = s.Longitude1;
                        y2 = s.Latitude;
                    }
                }
                int distance = (((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))) ^ (1 / 2);
                if (distance < 0)
                {
                    distance = distance * -1;
                }

                R.Distance = distance;
                int speed = 45;
                int time;
                time = distance / speed;

                R.Time = time;


            }
            return 0;

        }
      
         public Route find(string busnumber)
         { 
              foreach (Route R in RouteDL.myRoutes)
            {
                if ((R.BusNumber1 == busnumber))
                {
                    return R;
         }
                
            }
              return null;
            

        }
        public Route suggest()
        {
            int min =100;
            foreach ( Route R in search.searchr)
            {
                if (R.Time < min)
                {
                    min = R.Time;

                }
            }
            foreach (Route R in search.searchr)
            {
                if (R.Time == min)
                {
                    search.shortest.Add(R);
                }
            }
            return null;
        }
        public bool shortest(string busnumber, string routenumber)
        {
            bool find = true;
            foreach (Route R in search.shortest)
            {
                
                busnumber = R.BusNumber1;
                routenumber = R.RouteNumber1;
             
            }
            return find;
        }
        public List<Stops> getstops(string busnumber)
        {
            
             foreach (Route R in RouteDL.myRoutes)
            {
                if ((R.BusNumber1 == busnumber))
                {
                    return R.Mystops;
                }
        }
             return null;
        }
        public List<Route> getbusroute()
        {
            return RouteDL.myRoutes;
        }
        public Route getdetail(int ID)
        {
            return RouteDL.myRoutes[ID];





}
        public List<Route> getsearch()
        {
            return search.searchr;        
        }
        }
    }