using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_113_ArrayList;
using lab_112_collectoins;

namespace Lab_112_Collections_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var myTest = new ArrayLists();
            Assert.AreEqual(480, myTest.ArrayListMethod(1, 2, 3, 4));
            Assert.AreEqual(480, myTest.ArrayListMethod(10, 20, 30, 40));
        }
    }
}
