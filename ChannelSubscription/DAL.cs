using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChannelSubscription
{
    public class DAL
    {
        public static List<VODDetails> GetTargetedVODDetails(string UA, string Package)
        {
            List<VODDetails> lstobj = new List<VODDetails>();
            VODDetails OBJ = new VODDetails();
            OBJ.strAction = "LAUNCHFOLDER";
            OBJ.strAssetID = "21148";
            OBJ.strHeaderText = "SD";
            lstobj.Add(OBJ);
            OBJ = new VODDetails();
            OBJ.strAction = "LAUNCHFOLDER";
            OBJ.strAssetID = "34184";
            OBJ.strHeaderText = "HD";
            lstobj.Add(OBJ);
            OBJ = new VODDetails();
            OBJ.strAction = "LAUNCHFOLDER";
            OBJ.strAssetID = "12323";
            OBJ.strHeaderText = "HD";
            lstobj.Add(OBJ);
            OBJ = new VODDetails();
            OBJ.strAction = "LAUNCHFOLDER";
            OBJ.strAssetID = "5123";
            OBJ.strHeaderText = "HD";
            lstobj.Add(OBJ);
            return lstobj;
        }

    }
}