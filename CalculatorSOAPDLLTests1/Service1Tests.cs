using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorSOAPDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSOAPDLL.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDataUsingDataContractTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            Service1 add = new Service1();
            Assert.AreEqual(3,add.Add(1,2));
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.Fail();
        }
    }
}