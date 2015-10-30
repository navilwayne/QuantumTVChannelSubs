using System;
using System.Collections.Generic;
using Nest;
using NUnit.Framework;

namespace ChannelSubscription
{

    public class Service1 : IService1
    {
        
        public string OrderData(string stbUA, int Package)
        {
            string strResponse = string.Empty;
            try
            {
                foreach (VODDetails obj in DAL.GetTargetedVODDetails(stbUA, Package))
                {
                    strResponse += " { \"AssetId\" : \"" + obj.strAssetID + "\"  , \"Action\" :\"" + obj.strAction + "\", \"Header\" : \"" + obj.strHeaderText + "\" } ,";  
                }
            }

            catch (Exception e)
            {
                throw e;
            }


            return string.IsNullOrEmpty(strResponse) ? "[[]]" : "[["+strResponse.Substring(0,strResponse.Length-1)+"]]";
        }

        public string LogData()
        {
            string result = string.Empty;
            try
            {
                List<VODDetails> objList = new List<VODDetails>();

                objList = DAL.FetchData(); 

                #region ElasticSearch --Begin
                string indexName = "test";
                string typeName = "test01";
                var node = new Uri("http://localhost:9200");
                var settings = new ConnectionSettings(node);
                var client = new ElasticClient(settings);
                BulkDescriptor objbulk = new BulkDescriptor();
                foreach (var value in objList)
                {
                    objbulk.Index<object>(i => i
                        .Index(indexName)
                        .Type(typeName)
                        .Id(value.strAssetID)
                        .Document(value));
                    client.Bulk(objbulk);
                }

                result = "Data successfully inserted";
                #endregion ElasticSearch  --End
            }

            
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }
    }
}
