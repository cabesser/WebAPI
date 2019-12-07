using NUnit.Framework;
using WebCoreAPI;

namespace WebCoreAPI_Tests.Controller
{
    public class ScienceControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(84.2, "Fahrenheit", "Rankine", 543.5, ExpectedResult ="Correct", TestName = "It_Successfully_Converts_Fahrenheit_to_Rankine")]
        [TestCase(84.2, "Fahrenheit", "Rankine", 547.5, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Fahrenheit_to_Rankine")]
        [TestCase(84.2, "Fahrenheit", "Kelvin", 302.15, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Fahrenheit_to_Kelvin")]
        [TestCase(84.2, "Fahrenheit", "Kelvin", 302.51, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Fahrenheit_to_Kelvin")]
        [TestCase(84.2, "Fahrenheit", "Celsius", 29.12, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Fahrenheit_to_Celsius")]
        [TestCase(84.2, "Fahrenheit", "Celsius", 29.51, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Fahrenheit_to_Celsius")]
        [TestCase(84.2, "Fahrenheit", "bird",29.51, ExpectedResult = "Invalid", TestName ="It_Tests_Invalid_Fahrenheit")]
        public string It_Tests_Fahrenheit_Conversion_Methods(double inputTemp, string inputUnit, string conversionUnit, double convertedTemp)
        {
            var ctlr = new ScienceController();
            var result = ctlr.Get(inputTemp, inputUnit, conversionUnit, convertedTemp);

            return result;
        }

        [TestCase(-45.14, "Celsius", "Rankine", 410.42, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Celsius_to_Rankine")]
        [TestCase(-45.14, "Celsius", "Rankine", 410.52, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Celsius_to_Rankine")]
        [TestCase(-45.14, "Celsius", "Kelvin", 227.51, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Celsius_to_Kelvin")]
        [TestCase(-45.14, "Celsius", "Kelvin", 229.51, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Celsius_to_Kelvin")]
        [TestCase(-45.14, "Celsius", "Fahrenheit", -49.21, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Celsius_to_Fahrenheit")]
        [TestCase(-45.14, "Celsius", "Fahrenheit", -49.5, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Celsius_to_Fahrenheit")]
        [TestCase(-45.14, "Celsius", "bird", 29.51, ExpectedResult = "Invalid", TestName = "It_Tests_Invalid_Celsius")]
        public string It_Tests_Celsius_Conversion_Methods(double inputTemp, string inputUnit, string conversionUnit, double convertedTemp)
        {
            var ctlr = new ScienceController();
            var result = ctlr.Get(inputTemp, inputUnit, conversionUnit, convertedTemp);

            return result;
        }

        [TestCase(317.33, "Kelvin", "Rankine", 571.17, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Kelvin_to_Rankine")]
        [TestCase(317.33, "Kelvin", "Rankine", 571.5, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Kelvin_to_Rankine")]
        [TestCase(317.33, "Kelvin", "Celsius", 44.18, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Kelvin_to_Celsius")]
        [TestCase(317.33, "Kelvin", "Celsius", 44.51, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Kelvin_to_Celsius")]
        [TestCase(317.33, "Kelvin", "Fahrenheit", 111.52, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Kelvin_to_Fahrenheit")]
        [TestCase(317.33, "Kelvin", "Fahrenheit", 110.5, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Kelvin_to_Fahrenheit")]
        [TestCase(317.33, "Kelvin", "bird", 29.51, ExpectedResult = "Invalid", TestName = "It_Tests_Invalid_Kelvin")]
        public string It_Tests_Kelvin_Conversion_Methods(double inputTemp, string inputUnit, string conversionUnit, double convertedTemp)
        {
            var ctlr = new ScienceController();
            var result = ctlr.Get(inputTemp, inputUnit, conversionUnit, convertedTemp);

            return result;
        }

        [TestCase(444.5, "Rankine", "Celsius", -26.21, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Rankine_to_Celsius")]
        [TestCase(444.5, "Rankine", "Celsius", -26.51, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Rankine_to_Celsius")]
        [TestCase(444.5, "Rankine", "Kelvin", 246.94, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Rankine_to_Kelvin")]
        [TestCase(444.5, "Rankine", "Kelvin", 246.49, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Rankine_to_Kelvin")]
        [TestCase(444.5, "Rankine", "Fahrenheit", -15.17, ExpectedResult = "Correct", TestName = "It_Successfully_Converts_Rankine_to_Fahrenheit")]
        [TestCase(444.5, "Rankine", "Fahrenheit", -15.57, ExpectedResult = "Incorrect", TestName = "It_Fails_Converting_Rankine_to_Fahrenheit")]
        [TestCase(444.5, "Rankine", "bird", 29.51, ExpectedResult = "Invalid", TestName = "It_Tests_Invalid_Rankine")]
        public string It_Tests_Rankine_Conversion_Methods(double inputTemp, string inputUnit, string conversionUnit, double convertedTemp)
        {
            var ctlr = new ScienceController();
            var result = ctlr.Get(inputTemp, inputUnit, conversionUnit, convertedTemp);

            return result;
        }
    }
}
