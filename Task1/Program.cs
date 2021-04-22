// Noah Pascual
// MIS 3033-900
// Homework 2
// Task 1

//Create a console application. Your console application should contain two parallel arrays, as well as an error if they enter or spell the item name incorrectly.
//Array #1: should contain items apples, oranges, bananas, grapes, blueberries
//Array #2: should contain prices for each item. Apples are 0.99, oranges are 0.50, bananas are 0.50, grapes are 2.99, blueberries are 1.99.

//Your application can
//1) show all the items to users;
//2) prompt the user to enter the item they desire, then returns the item and the price of the item. Format the price as currency.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Task 1 ---\n\r";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            // Fruits and their prices (Arrays)
            String[] fruits = { "apples", "oranges", "bananas", "grapes", "blueberries" };
            double[] price = { 0.99, 0.50, 0.50, 2.99, 1.99 };

            // Display the fruit to the user (Part One: "show all the items to users")
            Console.WriteLine("\tList of available fruits:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"\t{fruits[i]} = {price[i]}");
            }

            // Ask the user to input their selection
            Console.Write("\nPlease enter which fruit you would like: >>> ");
            String name = Console.ReadLine();

            //check entered name & display price
            Boolean correct = false;
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i].Equals(name))
                {
                    correct = true;
                    Console.WriteLine($"\nExcellent! {fruits[i]} are {price[i]:C2}");
                }
            }
            // Validation If statment
            if (correct == false)
            {
                Console.Write("\nI'm sorry! That is an incorrect answer! >>>");
            }
            Console.ReadKey();
        }
    }
}
