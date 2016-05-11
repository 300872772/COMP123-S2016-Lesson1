using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hellowworldproject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void HelloWorldUnitTestConsolTestMethod()
        {
            //Arrange
            string expectedResult = "Hello World";
            //Act
            string result = COMP123_S2016_Lesson1.Program.HolowWorld();
            //Asert   
        }
    }
}
