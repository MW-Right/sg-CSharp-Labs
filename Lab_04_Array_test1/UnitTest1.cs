using System;
using Lab_04_array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_04_Array_test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_Array_Sum()               //Describe what you are testing with plain english
        {
            //Arrange (setup)
            TestingArray arrayInstance = new Lab_04_array.TestingArray();
            var expectedOutput = 285;
            //Act (run code)
            var actualOutput = arrayInstance.CreateArray(10);     //Used var because we didn't know what type would be returned at the time of writing the test

            //Assert (see if test is a pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void Check_Array_Variable_Size()               //Describe what you are testing with plain english
        {
            //Arrange (setup)
            TestingArray arrayInstance = new Lab_04_array.TestingArray();
            var expectedOutput = 2470;
            //Act (run code)
            var actualOutput = arrayInstance.CreateArray(20);     //Used var because we didn't know what type would be returned at the time of writing the test
            
            //Assert (see if test is a pass/fail)
            Assert.AreEqual(expectedOutput, actualOutput); 
        }
    }
}
