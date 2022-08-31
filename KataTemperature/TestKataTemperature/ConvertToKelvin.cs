using KataTemperature;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestKataTemperature
{
    [TestClass]
    public class ConvertToKelvin
    {
        [Test]
        public void ConvertFormFahrenheit_ToKelvinScale()
        {
            var expectedResult = TemperatureScale.Kelvin;
            var aTemp = new Temperature( 1231, TemperatureScale.Fahrenheit);
            aTemp = aTemp.toKelvin();
            Assert.AreEqual(expectedResult, aTemp.Scale);
        }
        
        [Test]
        public void ConvertFormCelsius_ToKelvinScale()
        {
            var expectedResult = TemperatureScale.Kelvin;
            var aTemp = new Temperature( 1231, TemperatureScale.Celsius);
            aTemp = aTemp.toKelvin();
            Assert.AreEqual(expectedResult, aTemp.Scale);
        }

        [Test]
        public void ConvertFromCelsius_toKelvinValue()
        {
            var expectedResultValue = 293.15; 
            var expectedResultScale = TemperatureScale.Kelvin;
            var aTemp = new Temperature( 20, TemperatureScale.Celsius);
            aTemp = aTemp.toKelvin();
            Assert.AreEqual(expectedResultValue, aTemp.Value);
            Assert.AreEqual(expectedResultScale, aTemp.Scale);
        }
        
        [Test]
        public void ConvertFromFahrenheit_toKelvinValue()
        {
            var expectedResultValue = 266.48; 
            var expectedResultScale = TemperatureScale.Kelvin;
            var aTemp = new Temperature( 20, TemperatureScale.Fahrenheit);
            aTemp = aTemp.toKelvin();
            Assert.AreEqual(expectedResultValue, aTemp.Value);
            Assert.AreEqual(expectedResultScale, aTemp.Scale); 
        }
        
        [Test]
        public void ConvertFromFahrenheit_toKelvinDiffValue()
        {
            var expectedResultValue = 266; 
            var expectedResultScale = TemperatureScale.Kelvin;
            var aTemp = new Temperature( 20, TemperatureScale.Fahrenheit);
            aTemp = aTemp.toKelvin();
            Assert.AreNotEqual(expectedResultValue, aTemp.Value);
            Assert.AreEqual(expectedResultScale, aTemp.Scale); 
        }
    }
}