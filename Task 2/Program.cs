// Noah Pascual
// MIS 3033-900
// Homework 2
// Task 1

// Redo task 1, however this time use a dictionary.  Your key value will be the fruit name and the value will be the price of the piece of fruit.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Task 2  ---\n\r";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            // Create a dictionary with the prices and their fruits
            Dictionary<string, double> Fruits = new Dictionary<string, double>();
            Fruits.Add("apples", 0.99);
            Fruits.Add("oranges", 0.5);
            Fruits.Add("bananas", 0.5);
            Fruits.Add("grapes", 2.99);
            Fruits.Add("blueberries", 1.99);

            // Display all items        
            Console.WriteLine("\tList of available fruits:");
            foreach (KeyValuePair<string, double> Fruit in Fruits)
            {
                Console.WriteLine($"\t{Fruit.Key} = {Fruit.Value:C2}");
            }

            // Ask the user to input their selection
            Console.Write("\nPlease enter which fruit you would like: >>> ");
            String item = Console.ReadLine();

            // Display price of users input
            if (Fruits.ContainsKey(item))   
            {
                Console.WriteLine($"Excellent! {item} are {Fruits[item]:C2}");
            }
            // Validation statment
            else   
            {
                Console.Write("\nI'm sorry! That is an incorrect answer! >>>");
            }
            Console.ReadKey(); 
        }
    }
}
