using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using For12;
namespace TestFor12
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AmaxBmin()
        {
            int b = 3, a = 4;
            int expected = 0;

            Progs c = new Progs();
            int result = c.For8(a, b);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void RightAns()
        {
            int b = 3, a = 1;
            int expected = 18;

            Progs c = new Progs();
            int result = c.For8(a, b);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void NMins()
        {
            int b = -2;
            int expected = 0;

            Progs c = new Progs();
            double result = c.For12(b);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Nzero()
        {
            int b = 0;
            int expected = 0;

            Progs c = new Progs();
            double result = c.For12(b);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void RightAn()
        {
            int b = 1;
            double expected = 1.1;

            Progs c = new Progs();
            double result = c.For12(b);

            Assert.AreEqual(expected, result);
        }
    }
}
