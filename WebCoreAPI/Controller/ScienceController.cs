using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCoreAPI.Models;

namespace WebCoreAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScienceController : ControllerBase
    {
        // GET: api/Science
        [HttpGet]
        public string Get(double inputTemp, string inputUnit, string conversionUnit, double convertedTemp)
        {
            ScienceTest model = new ScienceTest(inputTemp, inputUnit, conversionUnit, convertedTemp);

            switch (model.ConversionUnit)
            {
                case "Kelvin":
                    {
                        return ConvertToKelvin(model);
                    }
                case "Celsius":
                    {
                        return ConvertToCelsius(model);
                    }
                case "Fahrenheit":
                    {
                        return ConvertToFahrenheit(model);
                    }
                case "Rankine":
                    {
                        return ConvertToRankine(model);
                    }
                default:
                    return "Invalid";
            }
        }

        private string ConvertToKelvin(ScienceTest model)
        {
            switch(model.InputUnit)
            {
                case "Celsius":
                    {
                        return Math.Round((model.InputTemp + 273.15), MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                case "Fahrenheit":
                    {
                        return Math.Round(((model.InputTemp + 459.67) *5)/9, MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                case "Rankine":
                    {
                        return Math.Round((model.InputTemp * 5)/9, MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                case "Kelvin": //in case question uses same input unit as conversion unit
                    {
                        return Math.Round(model.InputTemp, MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                default:
                    return "Invalid";
            }
        }

        private string ConvertToCelsius(ScienceTest model)
        {
            switch (model.InputUnit)
            {
                case "Kelvin":
                    {
                        return Math.Round((model.InputTemp - 273.15), MidpointRounding.AwayFromZero) 
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero) 
                            ? "Correct" : "Incorrect";
                    }
                case "Fahrenheit":
                    {
                        return Math.Round(((model.InputTemp - 32) * 5)/9, MidpointRounding.AwayFromZero)
                                == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                                ? "Correct" : "Incorrect";
                    }
                case "Rankine":
                    {
                        return Math.Round(((model.InputTemp - 491.67) * 5)/9, MidpointRounding.AwayFromZero)
                                == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                                ? "Correct" : "Incorrect";
                    }
                case "Celsius": //in case question uses same input unit as conversion unit
                    {
                        return Math.Round(model.InputTemp, MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                default:
                    return "Invalid";
            }
        }

        private string ConvertToFahrenheit(ScienceTest model)
        {
            switch (model.InputUnit)
            {
                case "Celsius":
                    {
                        return Math.Round((model.InputTemp * 9)/5 + 32, MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                case "Kelvin":
                    {
                        return Math.Round((model.InputTemp * 9)/5 - 459.67, MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                case "Rankine":
                    {
                        return Math.Round((model.InputTemp - 459.67), MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                case "Fahrenheit": //in case question uses same input unit as conversion unit
                    {
                        return Math.Round(model.InputTemp, MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                default:
                    return "Invalid";
            }
        }

        private string ConvertToRankine(ScienceTest model)
        {
            switch (model.InputUnit)
            {
                case "Celsius":
                    {
                        return Math.Round(((model.InputTemp + 273.15) * 9)/5, MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                case "Fahrenheit":
                    {
                        return Math.Round((model.InputTemp + 459.67), MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                case "Kelvin":
                    {
                        return Math.Round((model.InputTemp * 9)/5, MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                case "Rankine": //in case question uses same input unit as conversion unit
                    {
                        return Math.Round(model.InputTemp, MidpointRounding.AwayFromZero)
                            == Math.Round(model.ConversionTemp, MidpointRounding.AwayFromZero)
                            ? "Correct" : "Incorrect";
                    }
                default:
                    return "Invalid";
            }
        }

        // POST: api/Science
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //use when DB hooked up
        }

        // PUT: api/Science/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //future use 
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //future use
        }
    }
}
