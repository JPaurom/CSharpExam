using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> items = new Dictionary<string, string>();

            while (true)
            {
                // Gives options 
                Console.WriteLine("1. Add Item and Item Description");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Show All");
                Console.WriteLine("4. Exit");
                // Lets you choose which option
                Console.Write("Choose a option between 1 and 4: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    // 1. Add Item and Item Description
                    case "1":
                        Console.Write("Enter the name of the item: ");
                        string newItem = Console.ReadLine();
                        Console.Write("item description: ");
                        string itemName = Console.ReadLine();

                        if (!items.ContainsKey(newItem))
                        {
                            items.Add(newItem, itemName);
                            Console.WriteLine("Item added.");
                        }
                        else
                        {
                            Console.WriteLine("This item already exists.");
                        }
                        break;

                    // 2. Remove an item
                    case "2":
                        Console.Write("Enter the name of the item to remove: ");
                        string itemToRemove = Console.ReadLine();

                        if (items.ContainsKey(itemToRemove))
                        {
                            items.Remove(itemToRemove);
                            Console.WriteLine("Item removed.");
                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                        break;
                        
                    // 3. Show all 
                    case "3":
                        if (items.Count > 0)
                        {
                            foreach (var item in items)
                            {
                                Console.WriteLine($"Item: {item.Key}, Item description: {item.Value}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No items available.");
                        }
                        break;
                    // 4. Exit
                    case "4":
                        Console.WriteLine("Exiting");
                        return;

                    default:
                        Console.WriteLine("Please choose between 1 and 4.");
                        break;

                }
            }
        }
    }
}
