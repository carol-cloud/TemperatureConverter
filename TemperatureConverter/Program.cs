using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, kelvin, fahrenheit;

            Console.WriteLine("Conversor de Temperaturas");
            Console.WriteLine("Insira a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            kelvin = celsius + 273.15;
            fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("Graus em Celsius: " + celsius);
            Console.WriteLine("Graus em Kelvin: " + kelvin);
            Console.WriteLine("Graus em Fahrenheit: " + fahrenheit);
            Console.ReadKey();

        }
    }
}
