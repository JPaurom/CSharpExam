using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First array
            string[] arrayNames = { "Alice", "John", "Mia" };
            // Loops the first array
            for (int i = 0; i < arrayNames.Length; i++)
            {
                // Prints each element with the message "Hello" at the beginning of each name
                Console.WriteLine("Hello " + arrayNames[i]);
            }

            // Second array
            int[] arrayValues = { 12, 45, 78, 3, 99, 21, 8 };
            // Sorts the second array in descending order
            Array.Sort(arrayValues);
            Array.Reverse(arrayValues);
            // Loops second array for each integer
            foreach (int i in arrayValues)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
           
            






        }
    }
}
