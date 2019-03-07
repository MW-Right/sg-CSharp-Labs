using System;
using Xunit;
using Lab_16_NUnit_XUnit_Tests;

namespace Lab_16_XUnitTest
{
    public class XUnitTestClass
    {
        [Fact]
        public void Lab_16_Tast_Math_Power()
        {
            //Arrange
            var expected01 = 64;
            var expected02 = 329;
            var instance01 = new TestMeNow();

            //Act
            var actual = instance01.TestThisMethodWorks(2, 4, 2);
            var actual02 = instance01.TestThisMethodWorks(7, 1, 3);

            //Assert
            Assert.Equal(expected01, actual);
            Assert.Equal(expected02, actual02);
        }
    }
}
