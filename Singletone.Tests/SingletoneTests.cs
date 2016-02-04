using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singletone.Common;

namespace Singletone.Tests
{
    [TestClass]
    public class SingletoneTests
    {
        [TestMethod]
        public void TestSingletone()
        {
            var car = Car.GetInstance();
            var car2 = Car.GetInstance();

            Assert.AreEqual(car, car2);
            Assert.AreSame(car, car2);
        }
    }
}
