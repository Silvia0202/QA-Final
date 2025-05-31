using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QAfinal
{
    [TestClass]
    public class UnitTest1
    {

        public bool CanDrive(int age)
        {

            const int drivingAge = 16; return age >= drivingAge;

        }


        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(CanDrive(17));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(CanDrive(16));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(CanDrive(15));
        }
    }
}
