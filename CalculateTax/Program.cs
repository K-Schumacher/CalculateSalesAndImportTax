using System;
using System.Collections.Generic;
using System.Data;

namespace CalculateTax
{
    class Program
    {
        static void Main(string[] args)
        {
            bool complete;

            do
            {
                Console.Clear();
                Cart.GetItemDetails();

                complete = (ConsoleLogging.PurchaseAnotherProduct() == "no");
            } while (complete == false);

            Console.Clear();
            Receipt.PrintReceipt();
        }
    }
}
