using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ChannelSubscription
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {


        public string GetQualification(string stbUA)
        {
            return string.Empty;
        }

        public string OrderData(string stbUA, string Package)
        {
            string strResponse = string.Empty;
            //ProcessOrder

            
            foreach (VODDetails obj in DAL.GetTargetedVODDetails(stbUA,Package))
            {

                strResponse += " { \"AssetId\" : \"" + obj.strAssetID + "\"  , \"Action\" :\"" + obj.strAction + "\", \"Header\" : \"" + obj.strHeaderText + "\" }";
            }
            return strResponse;
        }
    }
}
