using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;


namespace ChannelSubscription
{
    [TestFixture]
    public class Nunit
    {
        [TestCase]
        public void LogData()
        {
            string testResult = string.Empty;
            Service1 objSvc = new Service1();

            try
            {
                testResult = objSvc.LogData();
                Assert.AreEqual("Data successfully inserted",testResult);
            }

            catch (Exception e)
            {
                Assert.That(false, e.Message);
            }
        }
    }
}