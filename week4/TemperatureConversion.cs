using System;

namespace week4
{
    public class TemperatureConversion
    {
        private string _unit
        {
            get;
            set;
        }


        public TemperatureConversion(string unitType)
        {
           _unit = unitType;
        }

        private static double ToCelsius(double degree)
        {
            return (degree - 32) / 1.8;
        }
        private static double ToFahrenheit(double degree)
        {
            return degree * 1.8 + 32;
        }

        public double Conversion(double degree)
        {
            const string celsius = "celsius";
            const string fahrenheit = "fahrenheit";
            while (_unit.ToLower() != celsius && _unit.ToLower() != fahrenheit)
            {
                Console.WriteLine("Please enter a valid unit for temperature! fahrenheit/celsius");
               _unit = Console.ReadLine();

            }
            var convertedTemperature = _unit == celsius ? ToFahrenheit(degree) : ToCelsius(degree);
            return convertedTemperature;

        }
    }
}