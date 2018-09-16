using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace Tests
{
    [TestClass]
    public class BilUnitTest
    {
        [TestMethod]
        public void TestMethodPris()
        {
            Bil b = new Bil();
            var actuallResult = b.Pris();

            const decimal expectedResult = 240;
            
            Assert.AreEqual(expectedResult, actuallResult,
                "Test failed! The actual result is not the same as the expected result");
        }

        [TestMethod]
        public void TestMethodKøretøj()
        {
            Bil b = new Bil();
            var actuallResult = b.Køretøj();

            const string expectedResult = "Bil";
            
            Assert.AreEqual(expectedResult, actuallResult,
                "Test failed! The actual result is not the same as the expected result");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExceptionArgumentExceptionNummerplade()
        {
            new Bil {NummerPlade = "VP28106QQ"};
        }
        
        [TestMethod]
        public void TestMethodPrisPlusRabbat()
        {
            Bil b = new Bil {Brobizz = true};
            double actuallResult = (double) b.Pris();

            const double expectedResult = 228;
            
            Assert.AreEqual(expectedResult, actuallResult, 0.5,
                "Test failed! The actual result is not the same as the expected result");
        }
    }
}
