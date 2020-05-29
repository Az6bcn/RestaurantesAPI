using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantsAPI.Controllers;

namespace Restaurants.Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void GetSummaries_WhenCalled_Should_Return10Items()
        {
            // arrange
            var controller = new WeatherForecastController(null);

            // act 
            var res = controller.MethodForTesting();

            // assert
            Assert.AreEqual(10, res.Count());
        }
    }
}
