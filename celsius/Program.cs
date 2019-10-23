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
            double celsius;
            int userTemp;
            Console.WriteLine("Enter your temperature here: ");
            userTemp =int.Parse( Console.ReadLine());
            Console.WriteLine("If you wish to convert from Celsius to Fahrenheit, press 1");
            Console.WriteLine("If you wish to convert from Fahrenheit to Celsius, press 2");

            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                fahrenheit = (userTemp * 9) / 5 + 32;
                Console.WriteLine("Fahrenheit: " + fahrenheit);
            }
            else if (userChoice == 2)
            {
                celsius = (userTemp - 32) * 5 / 9;

                Console.WriteLine("Celsius: " + celsius);
            }
       

            Console.ReadLine();
        }
    }
}
