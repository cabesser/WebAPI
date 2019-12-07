using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreAPI.Models
{
    public class ScienceTest
    {
        public ScienceTest(double inputTemp, string inputUnit, string conversionUnit, double convertedTemp)
        {
            InputTemp = inputTemp;
            InputUnit = inputUnit;
            ConversionUnit = conversionUnit;
            ConversionTemp = convertedTemp;
        }

        public double InputTemp { get; set; }
        public string InputUnit { get; set; }
        public string ConversionUnit { get; set; }
        public double ConversionTemp { get; set; }
    }
}
