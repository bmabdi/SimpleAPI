using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleApi.Controllers;

namespace SimpleApi.Test
{
    [TestClass]
    public class UnitTest1
    {
        WeatherForecastController weatherForecastController = new WeatherForecastController();

        [TestMethod]
        public void TestMethod1()
        {
            IEnumerable<WeatherForecast> returnValue = weatherForecastController.Get();
            Assert.AreEqual(-7, returnValue.ToList().OrderBy(c => c.TemperatureC).ElementAt(0).TemperatureC);
        }
    }
}
