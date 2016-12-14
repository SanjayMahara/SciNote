using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearningFakes;
using Microsoft.QualityTools.Testing.Fakes;

namespace UnitTests
{
    [TestClass]
    public class TestUpgradeService
    {        
        [TestMethod]
        public void TestCurrentSWVersion()
        {
            int expected = 10;
            IUpgradeService us = new LearningFakes.Fakes.StubIUpgradeService()
                {
                    CurrentSWVersionInt32 = (DeviceID) => { return 10;},
                    IsSWUpgradeRequiredInt32 = (DeviceID) => { return true; }
                };
            int actual = us.currentSWVersion(1);
            Assert.AreEqual(expected, actual, "Same Versions found");

        }

        [TestMethod]
        public void TestLastUpgradeDate()
        {            
            using (ShimsContext.Create())
            {
                System.Fakes.ShimDateTime.NowGet =
                () =>
                { return new DateTime(2010, 11, 5); };
                var fakeTime = DateTime.Now; // It is always DateTime(2010, 11, 5); 
                Console.WriteLine(fakeTime.ToShortDateString());
            }
            var correctTime = DateTime.Now;
            Console.WriteLine(correctTime.ToShortDateString());
        }
    }
}
