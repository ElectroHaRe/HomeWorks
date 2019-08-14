using System;
using System.Collections.Generic;
using System.Linq;
namespace TemperatureConverter
{
    public enum TemperatureScale { Kelvin, Fahrenheit, Celsius }

    internal static class Converter
    {
        public static decimal ConvertToKelvin(decimal temperature, TemperatureScale scale)
        {
            decimal temp = 0;
            switch (scale)
            {
                case TemperatureScale.Kelvin:
                    temp = temperature;
                    break;
                case TemperatureScale.Fahrenheit:
                    temp = ConvertToKelvin((temperature - 32)/1.8m, TemperatureScale.Celsius);
                    break;
                case TemperatureScale.Celsius:
                    temp = temperature + 273.15m;
                    break;
                default:
                    throw new Exception("Temperature scale not recognized...");
            }
            if (temp < 0)
                throw new Exception("Below absolute zero...");
            return temp;
        }

        public static decimal ConvertToCelsius(decimal temperature, TemperatureScale scale)
        {
            decimal temp = 0;
            switch (scale)
            {
                case TemperatureScale.Kelvin:
                    temp = temperature - 273.15m;
                    break;
                case TemperatureScale.Fahrenheit:
                    temp = (temperature - 32) / 1.8m;
                    break;
                case TemperatureScale.Celsius:
                    temp = temperature;
                    break;
                default:
                    throw new Exception("Temperature scale not recognized...");
            }
            if (ConvertToKelvin(temp, TemperatureScale.Celsius) < 0)
                throw new Exception("Below absolute zero...");
            return temp;
        }

        public static decimal ConvertToFahrenheit(decimal temperature, TemperatureScale scale)
        {
            decimal temp = 0;
            switch (scale)
            {
                case TemperatureScale.Kelvin:
                    temp = ConvertToCelsius(temperature,TemperatureScale.Kelvin)+273.15m;
                    break;
                case TemperatureScale.Fahrenheit:
                    temp = temperature;
                    break;
                case TemperatureScale.Celsius:
                    temp = 1.8m*temperature+32;
                    break;
                default:
                    throw new Exception("Temperature scale not recognized...");
            }
            if (ConvertToKelvin(temp, TemperatureScale.Fahrenheit) < 0)
                throw new Exception("Below absolute zero...");
            return temp;
        }
    }
}
