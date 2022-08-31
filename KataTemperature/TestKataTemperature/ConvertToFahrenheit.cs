using KataTemperature;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestKataTemperature
{
    [TestClass]
    public class ConvertToFahrenheit
    {
        [Test]
        public void ConvertFormCelsius_ToFahrenheitScale()
        {
            var expectedResult = TemperatureScale.Fahrenheit;
            var aTemp = new Temperature( 1231, TemperatureScale.Celsius);
            aTemp = aTemp.ToFahrenheit();
            Assert.AreEqual(expectedResult, aTemp.Scale);
        }

        [Test]
        public void ConvertFromKelvin_ToFahrenheitScale()
        {
            var expectedResult = TemperatureScale.Fahrenheit;
            var aTemp = new Temperature( 1231, TemperatureScale.Kelvin);
            aTemp = aTemp.ToFahrenheit();
            Assert.AreEqual(expectedResult, aTemp.Scale);
        }

        [Test]
        public void ConvertFormKelvin_ToFahrenheitValue()
        {
            var expectedResultValue = -351.67;
            var expectedResultScale = TemperatureScale.Fahrenheit;
            var aTemp = new Temperature( 60, TemperatureScale.Kelvin);
            aTemp = aTemp.ToFahrenheit();
            Assert.AreEqual(expectedResultValue, aTemp.Value);
            Assert.AreEqual(expectedResultScale, aTemp.Scale);
        }

        [Test]
        public void ConvertFormCelsius_ToFahrenheitValue()
        {
            var expectedResultValue = 68;
            var expectedResultScale = TemperatureScale.Fahrenheit;
            var aTemp = new Temperature( 20, TemperatureScale.Celsius);
            aTemp = aTemp.ToFahrenheit();
            Assert.AreEqual(expectedResultValue, aTemp.Value);
            Assert.AreEqual(expectedResultScale, aTemp.Scale);
        }

        [Test]
        public void CovertFormFahrenheit_ToFahrenheitValue()
        { 
            var expectedResultValue = 20;
            var expectedResultScale = TemperatureScale.Fahrenheit;
            var aTemp = new Temperature( 20, TemperatureScale.Fahrenheit);
            aTemp = aTemp.ToFahrenheit();
            Assert.AreEqual(expectedResultValue, aTemp.Value);
            Assert.AreEqual(expectedResultScale, aTemp.Scale);
        }
    }
}