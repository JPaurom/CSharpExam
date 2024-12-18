using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks for an integer value
            Console.WriteLine("Write an integer value: ");
            // Converts the integer value to an int
            int userInput = Convert.ToInt32(Console.ReadLine());
            // Asks for a double 
            Console.WriteLine("Write a double: ");
            // Converts it to a double 
            double userDouble = Convert.ToDouble(Console.ReadLine());
            // Asks for a float
            Console.WriteLine("Write a float value: ");
            // Converts it to a float
            float floatNum = float.Parse(Console.ReadLine());
            // Asks for a string
            Console.WriteLine("Write a string value: ");
            // Converts it to a string value
            string string1 = Console.ReadLine();

            Console.WriteLine("---------------");
            Console.WriteLine(userInput);
            Console.WriteLine(userDouble);
            Console.WriteLine(floatNum);
            Console.WriteLine(string1); 

            // Int is a whole number
            // double is a floating point number
            // float is also a floating point number but its precise by only six or seven decimal digits
            // String is a text
        }
    }
}
