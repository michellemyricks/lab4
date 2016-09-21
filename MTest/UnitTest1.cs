using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string a = "3";
            string b = "2";

            string c = a + b;

            Assert.AreEqual("32", c);
        }
        [TestMethod]
        public void TestMethod_toNUmberTest()
        {
            string a = "3";
            string b = "2";

            int c = int.Parse(a) + int.Parse(b);
                
                

            Assert.AreEqual(5, c);
        }
    }
}
