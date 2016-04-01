using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Task_Tests
{


    /// <summary>
    ///This is a test class for TriangleAreaCalculatorTest and is intended
    ///to contain all TriangleAreaCalculatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TriangleAreaCalculatorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetArea
        ///</summary>
        [TestMethod()]
        public void GetAreaTest()
        {
            double a = 3; // TODO: Initialize to an appropriate value
            double b = 4; // TODO: Initialize to an appropriate value
            double c = 5; // TODO: Initialize to an appropriate value
            TriangleAreaCalculator target = new TriangleAreaCalculator(a, b, c); // TODO: Initialize to an appropriate value
            double expected = 6; // TODO: Initialize to an appropriate value
            double actual = target.GetArea();
            Assert.AreEqual(expected, actual, target.Precision);
        }
    }
}
