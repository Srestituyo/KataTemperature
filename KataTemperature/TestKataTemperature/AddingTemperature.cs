using KataTemperature;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestKataTemperature
{
    [TestClass]
    public class AddingTemperature
    { 
        
        [Test]
        public void AddingFahrenheit_toKelvin()
        {
            var expectedResultValue = 308.71;
            var aTempFahrenheit = new Temperature(60, TemperatureScale.Fahrenheit);
            var aTempKelvin = new Temperature(20, TemperatureScale.Kelvin);

            var aResult  = aTempKelvin.Add(aTempFahrenheit);
            Assert.AreEqual(expectedResultValue, aResult.Value);
        }
         
        
        [Test]
        public void AddingCelsius_toKelvin()
        {
            var expectedResultValue = 758.38;
            var aTempCelsius = new Temperature(2.0, TemperatureScale.Celsius);
            var aTempKelvin = new Temperature(483.23, TemperatureScale.Kelvin);

            var aResult  = aTempKelvin.Add(aTempCelsius);
            Assert.AreEqual(expectedResultValue, aResult.Value);
        }
        
        [Test]
        public void AddingCelsius_toFahrenheit()
        {
            var expectedResultValue = 518.83;
            var aTempCelsius = new Temperature(2.0, TemperatureScale.Celsius);
            var aTempFahrenheit= new Temperature(483.23, TemperatureScale.Fahrenheit);

            var aResult  = aTempFahrenheit.Add(aTempCelsius);
            Assert.AreEqual(expectedResultValue, aResult.Value);
        }
        
        [Test]
        public void Addingkelvin_toFahrenheit()
        {
            var expectedResultValue = 245.57;
            var aTempKelvin = new Temperature(123.34, TemperatureScale.Kelvin);
            var aTempFahrenheit= new Temperature(483.23, TemperatureScale.Fahrenheit);

            var aResult  = aTempFahrenheit.Add(aTempKelvin);
            Assert.AreEqual(expectedResultValue, aResult.Value);
        }
        
        [Test]
        public void Addingkelvin_toCelsius()
        {
            var expectedResultValue = 333.42;
            var aTempKelvin = new Temperature(123.34, TemperatureScale.Kelvin);
            var aTempCelsius= new Temperature(483.23, TemperatureScale.Celsius);

            var aResult  = aTempCelsius.Add(aTempKelvin);
            Assert.AreEqual(expectedResultValue, aResult.Value);
        }
        
        [Test]
        public void AddingFahrenheit_toCelsius()
        {
            var expectedResultValue = 472.86;
            var aTempFahrenheit = new Temperature(13.34, TemperatureScale.Fahrenheit);
            var aTempCelsius= new Temperature(483.23, TemperatureScale.Celsius);

            var aResult  = aTempCelsius.Add(aTempFahrenheit);
            Assert.AreEqual(expectedResultValue, aResult.Value);
        }
         

         
    }
}