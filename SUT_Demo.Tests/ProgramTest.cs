using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SUT_Demo;

namespace SUT_Demo.Tests
{
    [TestFixture]
    public class ProgramTest
    {
        static int myExpectedResult;
        static Program p1;

        [SetUp] // code here is executed before tests are executed

        public static void Init()
        {
            p1 = new Program();
        }

        [Test]
        public static void Add_SimpleValues_Calculated_1()
        {
            // AAA Pattern
            // Arrange
            // Act
            // Assert
            myExpectedResult = 9;//what my code should be returning
            int actualResult = p1.Add(4, 5);//call the SUT method
            Assert.AreEqual(myExpectedResult, actualResult);
        }

        [Test]
        public static void Add_SimpleValues_Calculated_2()
        {
            myExpectedResult = 0;//what my code should be returning
            int actualResult = p1.Add(0, 0);//call the SUT method
            Assert.AreEqual(myExpectedResult, actualResult);
        }

        //[Test]
        //public static void  Add_NotImplemented_ExceptionThrown()
        //{
        //    Assert.AreEqual("not implemented", "not implemented");
        //}

        //Paramaterised Test - allows us to group a bunch of tests
        ////[TestCase(0, 0, ExpectedResult = 0)]
        ////[TestCase(-1, 10, ExpectedResult = 9)]
        ////[TestCase(5, 15, ExpectedResult = 20)]
        ////[TestCase(15, 15, ExpectedResult = 30)]
    }
}
