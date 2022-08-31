using KataTemperature;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestKataTemperature
{
    [TestClass]
    public class ConvertToCelsius
    {
        [Test]
        public void ConvertFormFahrenheit_ToCelsiusScale()
        {
            var expectedResult = TemperatureScale.Celsius;
            var aTemp = new Temperature( 1231, TemperatureScale.Fahrenheit);
            aTemp = aTemp.toCelsius();
            Assert.AreEqual(expectedResult, aTemp.Scale);
        }
        
        [Test]
        public void ConvertFormKelvin_ToCelsiusScale()
        {
            var expectedResult = TemperatureScale.Celsius;
            var aTemp = new Temperature( 1231, TemperatureScale.Kelvin);
            aTemp = aTemp.toCelsius();
            Assert.AreEqual(expectedResult, aTemp.Scale);
        }
        
        [Test]
        public void ConvertFormkelvin_ToCelsiusDiffValue()
        {
            var expectedResultValue = 68;
            var expectedResultScale = TemperatureScale.Celsius;
            var aTemp = new Temperature( 20, TemperatureScale.Kelvin);
            aTemp = aTemp.toCelsius();
            Assert.AreNotEqual(expectedResultValue, aTemp.Value);
            Assert.AreEqual(expectedResultScale, aTemp.Scale);
        }
        
        
        [Test]
        public void ConvertFormkelvin_ToCelsiusValue()
        {
            var expectedResultValue = -253.15;
            var expectedResultScale = TemperatureScale.Celsius;
            var aTemp = new Temperature( 20, TemperatureScale.Kelvin);
            aTemp = aTemp.toCelsius();
            Assert.AreEqual(expectedResultValue, aTemp.Value);
            Assert.AreEqual(expectedResultScale, aTemp.Scale);
        }
        
        [Test]
        public void ConvertFormFahrenheit_ToCelsiusDiffValue()
        {
            var expectedResultValue = -253;
            var expectedResultScale = TemperatureScale.Celsius;
            var aTemp = new Temperature( 20, TemperatureScale.Fahrenheit);
            aTemp = aTemp.toCelsius();
            Assert.AreNotEqual(expectedResultValue, aTemp.Value);
            Assert.AreEqual(expectedResultScale, aTemp.Scale);
        }
        
        [Test]
        public void ConvertFormFahrenheit_ToCelsiusValue()
        {
            var expectedResultValue = -253.15;
            var expectedResultScale = TemperatureScale.Celsius;
            var aTemp = new Temperature( 20, TemperatureScale.Fahrenheit);
            aTemp = aTemp.toCelsius();
            Assert.AreNotEqual(expectedResultValue, aTemp.Value);
            Assert.AreEqual(expectedResultScale, aTemp.Scale);
        }
        
    }
}