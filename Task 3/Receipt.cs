// Noah Pascual
// MIS 3033-900
// Homework 2
// Task 3

using System;

namespace Task_3
{
    class Receipt
    {
        private int customerID;
        private int cogs;
        private int gears;
        private DateTime saleDate;

        // Constructors 
        public Receipt()
        {
            customerID = 0;
            cogs = 0;
            gears = 0;
            saleDate = DateTime.Now;
        }

        //Receipt
        public Receipt(int id, int cog, int gear)
        {
            customerID = id;
            cogs = cog;
            gears = gear;
            saleDate = DateTime.Now;
        }

        // Total Amount w/ markup
        public double calculateTotal()
        {
            double totalPrice;
            double cogPrice = 79.99;
            double gearPrice = 250;
            const double markup1 = 1.15;
            const double markup2 = 1.125;
            double discountPrice;
            // Standard Total with 15% Markup
            totalPrice = (cogs * cogPrice + gears * gearPrice) * markup1;

            // "However, if the customer purchases more than 10 of either item or a combined quantity of 16 items we only markup the items by 12.5%."  
            if (cogs + gears >= 16 || cogs > 10 || gears > 10)
            {
                discountPrice = (cogs * cogPrice + gears * gearPrice) * markup2;
            }
            else
            {
                discountPrice = (cogs * cogPrice + gears * gearPrice) * markup1;
            }
            return totalPrice;
        }

        // Tax Amount
        public double calculateTaxAmount()
        {
            double totalPrice = calculateTotal();
            double taxamount = 0;

            taxamount = totalPrice + totalPrice * 0.089;
            return taxamount;
        }

        // Net Amount
        public double calculateNetAmount()
        {
            return calculateTotal() + calculateTaxAmount();
        }

        // Receipt
        public void PrintReceipt()
        {
            Console.WriteLine($"\n\t Customer ID:     {customerID}");
            Console.WriteLine($"\t Cog Amount:      {cogs}");
            Console.WriteLine($"\t Gear Amount:     {cogs}");
            Console.WriteLine($"\t Sale Date:       {saleDate}");
            Console.WriteLine($"\t Total Amout:     {calculateTotal():C2}");
            Console.WriteLine($"\t Total Amout:     {calculateTaxAmount():C2}");
            Console.WriteLine($"\t Total Amout:     {calculateNetAmount():C2}");
        }
    }
}