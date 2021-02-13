using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateTax
{
    class ConsoleLogging
    {
        public static void GetName(CartItem product)
        {
            Console.WriteLine("Enter a product you wish to purchase.");
            product.Name = InputValidation.IsNameNull();
        }

        public static void GetQuantity(CartItem product)
        {
            Console.WriteLine("Quantity?");
            product.Quantity = InputValidation.ParseQuantity();
        }

        public static void GetPrice(CartItem product)
        {
            Console.WriteLine("Price per product?");
            product.Price = InputValidation.ParsePrice();
            
        }

        public static void IsImported(CartItem product)
        {
            Console.WriteLine("Is this product imported?");
            var userInput = Console.ReadLine().ToLower();
            InputValidation.VerifyIsImported(userInput);
            if (userInput == "yes")
            {
                product.Imported = true;
            }
        }

        public static void IsTaxable(CartItem product) { 

            Console.WriteLine("Is this a book, food, or medical product?");
            var userInput = Console.ReadLine().ToLower();
            InputValidation.VerifyIsTaxable(userInput);
            if (userInput == "yes")
            {
                product.TaxExcempt = true;
            }
        }

        public static string PurchaseAnotherProduct()
        {
            Console.WriteLine("Do you have any other items?");
            var userInput = Console.ReadLine().ToLower();
            string moveOn = InputValidation.VerifyPurchaseAnotherProduct(userInput);
            return moveOn;
        }
    }
}
