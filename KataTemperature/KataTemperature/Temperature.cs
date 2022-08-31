using System;

namespace KataTemperature
{
    public class Temperature
    {
        public double Value { get; set; }

        public TemperatureScale Scale { get; set; }

        public Temperature(double theValue, TemperatureScale theScale)
        {
            Value = theValue;
            Scale = theScale;
        }

        public Temperature Add(Temperature theTemperatureToAdd)
        {
            var aTemp = new Temperature(this.Value, this.Scale);
            if (aTemp.Scale != theTemperatureToAdd.Scale && aTemp.Scale == TemperatureScale.Kelvin)
            {
                aTemp.Value = aTemp.Value + theTemperatureToAdd.toKelvin().Value;
            }else if (aTemp.Scale != theTemperatureToAdd.Scale && aTemp.Scale == TemperatureScale.Fahrenheit)
            {
                aTemp.Value = aTemp.Value + theTemperatureToAdd.ToFahrenheit().Value;
            }else if (aTemp.Scale != theTemperatureToAdd.Scale && aTemp.Scale == TemperatureScale.Celsius)
            {
                aTemp.Value = aTemp.Value + theTemperatureToAdd.toCelsius().Value;
            }

            aTemp.Value = Math.Round(aTemp.Value, 2); 
            return aTemp;
        }

        public Temperature ToFahrenheit()
        {
            var aTemperature = new Temperature(this.Value,this.Scale);
            
            if (aTemperature.Scale == TemperatureScale.Celsius)
            {
                aTemperature.Value = (aTemperature.Value * 9 / 5) + 32; 
                aTemperature.Scale = TemperatureScale.Fahrenheit; 
            }else if (aTemperature.Scale == TemperatureScale.Kelvin)
            {
                aTemperature.Value = (aTemperature.Value - 273.15) * 9 / 5 + 32;  
                aTemperature.Scale = TemperatureScale.Fahrenheit; 
            }
            
            aTemperature.Value = Math.Round(aTemperature.Value, 2); 
            return aTemperature;
        }

        public Temperature toKelvin()
        {
            var aTemperature = new Temperature(this.Value, this.Scale);
            
            if (aTemperature.Scale == TemperatureScale.Celsius)
            {
                aTemperature.Value = aTemperature.Value + 273.15;
                aTemperature.Scale = TemperatureScale.Kelvin;
            }else if (aTemperature.Scale == TemperatureScale.Fahrenheit)
            {
                aTemperature.Value = 5 * (aTemperature.Value - 32) / 9 + 273.15;
                aTemperature.Scale = TemperatureScale.Kelvin;
            }

            aTemperature.Value = Math.Round(aTemperature.Value, 2);
            return aTemperature;
        }

        public Temperature toCelsius()
        {
            var aTemperature = new Temperature(this.Value, this.Scale);
            if (aTemperature.Scale == TemperatureScale.Fahrenheit)
            {
                aTemperature.Value = 5 * (aTemperature.Value - 32) / 9; 
                aTemperature.Scale = TemperatureScale.Celsius;
            }else if (aTemperature.Scale == TemperatureScale.Kelvin)
            {
                aTemperature.Value = aTemperature.Value - 273.15;
                aTemperature.Scale = TemperatureScale.Celsius;
            }

            aTemperature.Value = Math.Round(aTemperature.Value, 2);
            return aTemperature;
        }
    }
    
    

    public enum TemperatureScale{
        Kelvin = 'K',
        Celsius =  'C',
        Fahrenheit = 'F'
    }
}