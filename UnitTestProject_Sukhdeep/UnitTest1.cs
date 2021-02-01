using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalMovies_Sukhdeep;

namespace UnitTestProject_Sukhdeep
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTestSukhdeep ownCode = new UnitTestSukhdeep();
            var result = ownCode.Additions(5, 7);
            Assert.IsTrue(result == 12);
        }
    }
}
