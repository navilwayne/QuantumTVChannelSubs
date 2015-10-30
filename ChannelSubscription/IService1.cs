using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ChannelSubscription
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {


        [OperationContract]
        string GetQualification(string stbUA);

        [OperationContract]
        string OrderData(string stbUA, int Package);

        [OperationContract]
        string LogData();
    }

    [DataContract]
    public class AppData
    {

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string IosCusID{get;set;}
        [DataMember]
        public string AndroidCustID { get; set; }
            
    }
}
