using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace Tests
{
    [TestClass]
    public class MCUnitTest
    {
        [TestMethod]
        public void TestMethodPris()
        {
            MC mc = new MC();
            var actuallResult = mc.Pris();

            const decimal expectedResult = 125;
            
            Assert.AreEqual(expectedResult, actuallResult,
                "Test failed! The actual result is not the same as the expected result");
        }

        [TestMethod]
        public void TestMethodKøretøj()
        {
            MC mc = new MC();
            var actuallResult = mc.Køretøj();

            const string expectedResult = "MC";
            
            Assert.AreEqual(expectedResult, actuallResult,
                "Test failed! The actual result is not the same as the expected result");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExceptionArgumentExceptionNummerplade()
        {
            new MC {NummerPlade = "VP28106QQ"};
        }
        
        [TestMethod]
        public void TestMethodPrisPlusRabbat()
        {
            MC mc = new MC {Brobizz = true};
            double actuallResult = (double) mc.Pris();

            const double expectedResult = 118.75;
            
            Assert.AreEqual(expectedResult, actuallResult, 0.5,
                "Test failed! The actual result is not the same as the expected result");
        }
    }
}
