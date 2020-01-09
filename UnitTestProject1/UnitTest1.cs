using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double risposta_aspettata= 3.5;
            double risposta = Class1.Primo();
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        public void TestMethod2()
        {
            double risposta_aspettata = 3.5;
            double risposta = Class1.Secondo();
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        public void TestMethod3()
        {
            double risposta_aspettata = 7;
            double risposta = Class1.Terzo();
            Assert.AreEqual(risposta_aspettata, risposta);
        }
    }
}
