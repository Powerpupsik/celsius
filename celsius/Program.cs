using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;

            double celsius = 79;
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

        
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Celsius: " + celsius);

            Console.ReadLine();
        }
    }
}
