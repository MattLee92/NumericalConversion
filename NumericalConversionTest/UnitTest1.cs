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
            string expected = "One Hundred and Twenty-Three dollars and Twenty cents";

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

        [TestMethod]
        public void test_input_millions_correctWords()
        {

            decimal userinput = 1258369;
            string expected = "One Million Two Hundred and Fifty Eight Thousand Three Hundred and Sixty-Nine dollars ";

            var result = testconverter.convertInput(userinput);

            Assert.AreEqual(result, expected);

        }


        [TestMethod]
        public void test_input_highest()
        {

            decimal userinput = 999999999.99m;
            string expected = "Nine Hundred and Ninety Nine Million Nine Hundred and Ninety Nine Thousand Nine Hundred and Ninety-Nine dollars and Ninety-Nine cents";

            var result = testconverter.convertInput(userinput);

            Assert.AreEqual(result, expected);

        }









    }
}
