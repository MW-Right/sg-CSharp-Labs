using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_16_NUnit_XUnit_Tests;

namespace Lab_16_MSTest
{
    [TestClass]
    public class MSTestClass
    {
        [TestInitialize]
        public void Initialize()
        {
            System.Console.WriteLine("Initialising tests");
        }
        [TestMethod]
        public void TestLab16()
        {
            //Arrange
            var expected01 = 216;
            var expected02 = 1296;
            var instance01 = new TestMeNow();

            //Act
            var actual = instance01.TestThisMethodWorks(2, 3, 3);
            var actual02 = instance01.TestThisMethodWorks(2, 3, 4);

            //Assert
            Assert.AreEqual(expected01, actual);
            Assert.AreEqual(expected02, actual02);
        }
        [TestCleanup]
        public void Cleanup()
        {
            //Clean up code goes here, for example resetting the database
            System.Console.WriteLine("Cleaned up after tests");
        }
    }
}
