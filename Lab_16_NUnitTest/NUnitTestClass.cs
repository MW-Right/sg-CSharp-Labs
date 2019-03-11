using NUnit.Framework;
using System;
using Lab_16_NUnit_XUnit_Tests;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2,3,2,36)]
        [TestCase(4,3,3,1728)]
        public void Lab_16_NUnitTest01(int x, int y, int p, int expected)
        {
            //Arrange
            var instance01 = new TestMeNow();

            //Act
            var actual = instance01.TestThisMethodWorks(x, y, p);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}