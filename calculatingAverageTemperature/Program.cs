using System;

namespace calculatingAverageTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperatures = {12,16,20,27,28,19};

            PrintAverage(temperatures);
        }

             static void PrintAverage(double[] temperatures)
        {
            double result = CalculateAverage(temperatures);
            
            Console.WriteLine($"The average temperature is: {result}");
        }

     static double CalculateAverage(double[] temperatures)
        {
              double sum = 0;
            foreach(var temperature in temperatures){
                sum += temperature;
            }
            
            return sum / temperatures.Length;
        }
    }
}