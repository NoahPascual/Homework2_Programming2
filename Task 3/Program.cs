// Noah Pascual
// MIS 3033-900
// Homework 2
// Task 3

// You will be creating an application to help our sales associates sell our main products, cogs and gears.  
// Cogs have a whole sale price of $79.99 and gears have a whole sale price of $250.00.  
// When our sales associates are selling to our customers on the floor, we have a standard 15% markup on our wholesale price for our sales price.  
// However, if the customer purchases more than 10 of either item or a combined quantity of 16 items we only markup the items by 12.5%.  On top of this, the sales tax for all sales is 8.9%.
// Create a console application that will prompt the sales associate for the number of cogs, the number of gears  as well as their Customer ID for a sales order.  
// Once the user has input all of the data needed, create a new instance of the Receipt(or a new Receipt object), call the PrintReceipt method on the object and then store it in some sort of collection.  
// Then you should ask if there is another order that needs to be placed and repeat the process of order entry.
// After all orders are entered, give the user options to either print all receipts based off of a CustomerID, print all receipts for the day, or print the receipt for the sale that had the highest total.  
// Keep prompting the user to see if they would like to perform another function until they indicate that they do not.

// Constructors - Set all of the instance variables to their appropriate default values.  
// For the SaleDate, set it to the current date and time.

// CalculateTotal - The CalculateTotal method will tabulate the final total for the sale.  
// To do this, you will need to call the CalculateNetAmount method and the CalculateTaxAmount method to get the net amount and the tax amount.  
// You will then add the tax amount from the net amount and return that value.

// PrintReceipt - The PrintReceipt method will write to the console all the details about the sale in an easy to read format.  
// Not all on just one line, must include what the value represents (e.g. not just 5 but # of Cogs : 5).  
// Format all values appropriately. 

// CalculateTaxAmount - The CalculateTaxAmount method will tabulate the total tax for the sale.  
// To do this, you will need to call the CalculateNetAmount and then multiple by your class (instance)variable, SalesTaxPercent.
// You will then return the total tax for the sale (Note: this should be a positive value).

// CalculateNetAmount - The CalculateNetAmount method will tabulate the net price of the sale.  
// You will need to figure out what markup percent we need to add to our base unit prices for the Cog and Gears based upon the number purchased.  
// Once you do this, the formula for to calculate the netAmount is:
// netAmount = CogQuantity * Cog Price with markup + GearQuantity * Gear Price with markup

// You will then return the net amount for the sale from the method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_3
{
    class Program
    {

        static void Main(string[] args)
        {
            string title = "--- Task 3 ---\n\r";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            // Main Method Variables
            int customerID;
            int cogs;
            int gears;

            // User Input
            Console.Write("Please enter the customers' id#: >>>");
            int.TryParse(Console.ReadLine(), out customerID);

            Console.Write("How many Cog's would you like to purchase? >>>");
            int.TryParse(Console.ReadLine(), out cogs);

            Console.Write("How many Gear's would you like to purchase? >>>");
            int.TryParse(Console.ReadLine(), out gears);

            Receipt receipt = new Receipt(customerID, cogs, gears);
            receipt.PrintReceipt();
            Console.ReadKey();
        }

    }
}

