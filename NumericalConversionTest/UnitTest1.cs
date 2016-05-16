using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericalConversion.Class;

namespace NumericalConversionTest
{
    [TestClass]
    public class UnitTest1
    {
        NumConvert testconverter = new NumConvert();
        [TestMethod]
        public void test_correct_return()
        {

            decimal userinput = 123.20m;
            string expected = "One Hundred and Twenty Three dollars and Twenty cents";

            var result = testconverter.convertInput(userinput);

            Assert.AreEqual(result, expected);

        }

        [TestMethod]
        public void test_incorrect_input()
        {

            decimal userinput = 100000;
            string expected = "";

            var result = testconverter.convertInput(userinput);

            Assert.AreEqual(result, expected);

        }

        [TestMethod]
        public void test_input_singular()
        {

            decimal userinput = 1.01m;
            string expected = "One dollar and One cent";

            var result = testconverter.convertInput(userinput);

            Assert.AreEqual(result, expected);

        }
    }
}
