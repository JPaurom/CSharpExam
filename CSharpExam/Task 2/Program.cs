using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks you to write a number
            Console.WriteLine("Write a number: ");
            string input = Console.ReadLine();
            // Converts input string to int
            if (int.TryParse(input, out int number))

            // If number is more than 0, its positive
            if (number > 0)
            {
                Console.WriteLine("The number is positive. ");
            }
            // If number is less than its negative
            else if (number < 0)
            {
                Console.WriteLine("The number is negative. ");
            }
            // If number equals to 0 then the number is 0
            else
            {
                Console.WriteLine("The number is 0");
            }
            else 
            // Invalid input 
            {
                {
                    Console.WriteLine("Invalid input ");
                }
            }
            Console.ReadLine();

        }
    }
}
