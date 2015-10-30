using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace ChannelSubscription
{
    public class DAL
    {
        public static List<VODDetails> GetTargetedVODDetails(string UA, int Package)
        {
            List<VODDetails> lstobj = new List<VODDetails>();
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnString"]))
            {
                conn.Open();
                SqlCommand objCommandToExec = new SqlCommand("uspGetRecommendations", conn);
                objCommandToExec.CommandType = CommandType.StoredProcedure;
                SqlParameter[] objarray = new SqlParameter[2];
                SqlParameter objparam = new SqlParameter("@stbUA", SqlDbType.VarChar, 10);
                objparam.Value = UA;
                objarray[0] = objparam;
                objparam = new SqlParameter("@Package", SqlDbType.Int);
                objparam.Value = Package;
                objarray[1] = objparam;
                objCommandToExec.Parameters.AddRange(objarray);
                SqlDataReader objSDR = objCommandToExec.ExecuteReader();
                    while (objSDR.Read())
                    {
                        VODDetails OBJ = new VODDetails();
                        OBJ.strAction = objSDR["strAction"].ToString();
                        OBJ.strAssetID = objSDR["strAssetID"].ToString();
                        OBJ.strHeaderText = objSDR["strHeaderText"].ToString();
                        lstobj.Add(OBJ);
                    }
            }
            return lstobj;
        }

        public static List<VODDetails> FetchData()
        {
            List<VODDetails> lstobj = new List<VODDetails>();
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnString"]))
            {
                conn.Open();
                SqlCommand objCommandToExec = new SqlCommand("select  * from VodDetails ", conn);                
                SqlDataReader objSDR = objCommandToExec.ExecuteReader();
                while (objSDR.Read())
                {
                    VODDetails OBJ = new VODDetails();
                    OBJ.strAction = objSDR["strAction"].ToString();
                    OBJ.strAssetID = objSDR["strAssetID"].ToString();
                    OBJ.strHeaderText = objSDR["strHeaderText"].ToString();
                    OBJ.AssentName = objSDR["AssetName"].ToString();
                    lstobj.Add(OBJ);
                }
            }
            return lstobj;
            
         
        }
    }
}