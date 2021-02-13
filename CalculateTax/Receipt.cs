using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateTax
{
    class Receipt
    {
        public static void PrintReceipt()
        {
            foreach (var item in Cart.GroceryList)
            {
                Console.WriteLine($"{item.Name}: {item.Price * item.Quantity:c2} ({item.Quantity} @ {item.Price:c2})");
                Console.WriteLine("------------------");
            }

            Cart.CalculateTotal();

            WriteTotals();
        }

        public static void WriteTotals()
        {
            Console.WriteLine($"Sales Tax: {Cart.SalesTaxTotal + Cart.ImportTaxTotal:c2}");
            Console.WriteLine($"Total: {Cart.Total:c2}");
        }

    }
}
