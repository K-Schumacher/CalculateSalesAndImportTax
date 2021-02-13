using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateTax
{
    class InputValidation
    {
        public static string IsNameNull()
        {
            CartItem product = new CartItem();
            string name = Console.ReadLine();
            product.Name = name;
            bool isEmptyOrNull = String.IsNullOrEmpty(name);

            if (isEmptyOrNull == true)
            {
                Console.WriteLine($"\"{product.Name}\": is not a valid product name.");
                ConsoleLogging.GetName(product);
                return product.Name;
            }
            return product.Name;
        }

        public static int ParseQuantity()
        { 
            CartItem product = new CartItem();
            bool parsed = int.TryParse(Console.ReadLine(), out int quantity);
            product.Quantity = quantity;

            if (parsed == true)
            {
                if (product.Quantity <= 0)
                {
                    Console.WriteLine($"{product.Quantity}: is not a valid quantity.");
                    ConsoleLogging.GetQuantity(product);
                }
                return product.Quantity;
            }
            ConsoleLogging.GetQuantity(product);
            return product.Quantity;
        }
        public static decimal ParsePrice()
        {
            CartItem product = new CartItem();
            bool parsed = decimal.TryParse(Console.ReadLine(), out decimal price);
            product.Price = price;

            if (parsed == true)
            {
                if (product.Price <= 0)
                {
                    Console.WriteLine($"{product.Price}: is not a valid price");
                    ConsoleLogging.GetPrice(product);
                }
                return product.Price;
            }
            ConsoleLogging.GetPrice(product);
            return product.Price;
        }

        public static string VerifyIsImported(string userInput)
        {
            CartItem product = new CartItem();

            if (userInput == "yes" || userInput == "no")
            {
                return userInput;
            }
            else
            {
                Console.WriteLine($"\"{userInput}\": is not a valid entry. Please enter yes or no.");
                ConsoleLogging.IsImported(product);
                return userInput;
            }
        }
        public static string VerifyIsTaxable(string userInput)
        {
            CartItem product = new CartItem();

            if (userInput == "yes" || userInput == "no")
            {
                return userInput;
            }
            else
            {
                Console.WriteLine($"\"{userInput}\": is not a valid entry. Please enter yes or no.");
                ConsoleLogging.IsTaxable(product);
                return userInput;
            }
        }
        public static string VerifyPurchaseAnotherProduct(string userInput)
        {
            
            
            if (userInput.ToLower() == "yes" || userInput.ToLower() == "no")
            {
                return userInput;
            }
            else
            {
                Console.WriteLine($"\"{userInput}\": is not a valid entry. Please enter yes or no.");
                ConsoleLogging.PurchaseAnotherProduct();
                return userInput;
            }
        }
    }
}
