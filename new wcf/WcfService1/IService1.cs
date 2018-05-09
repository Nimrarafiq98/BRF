using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool isvalid(string username, string password,string Type);
        [OperationContract]

        bool registration(string username, string password,string type);
        [OperationContract]
        bool reset(string username, string password, string ConfirmPassword);
        [OperationContract]
        bool update(string busnumber, string routenumber, string newbusnum, string newroutenum);
        [OperationContract]
        bool updatestops(string busnumber,string stopname, string newstopname);

        [OperationContract]
        bool addroute(string BusNumber, string RouteNumber);
        [OperationContract]
        Route suggest();
        [OperationContract]
        bool shortest(string busnumber, string routenumber);

        [OperationContract]
        
        bool addstop(string busnumber,string StopNumber,string longitude,string latitude);


        [OperationContract]

        List<Stops> getstops(string busnumber);
        [OperationContract]
        List<Route> getbusroute();

        [OperationContract]
        Route getdetail(int ID);
        [OperationContract]
        Route find(string busnumber);
        [OperationContract]
        bool searchpick(string pickup);
        [OperationContract]
        bool searchdown(string dropdown,string pickup);
        
        [OperationContract]
        List<Route> getsearch();
        [OperationContract]
        int distance(string pickup,string dropdown);



         [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
       
        
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
