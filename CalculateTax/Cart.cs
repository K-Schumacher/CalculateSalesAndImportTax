using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateTax
{
    public class Cart
    {
        public static decimal Total { get; set; }
        public static decimal SubTotal { get; set; }
        public static List<CartItem> GroceryList { get; set; } = new List<CartItem>();
        public static decimal SalesTaxTotal { get; set; }
        public static decimal ImportTaxTotal { get; set; }

        public static void CreateProduct(CartItem product)
        {
            ConsoleLogging.GetName(product);
            ConsoleLogging.GetQuantity(product);
            ConsoleLogging.GetPrice(product);
        }

        public static void GetItemDetails()
        {
            var product = new CartItem();

            CreateProduct(product);

            SubTotal += product.Quantity * product.Price;

            ConsoleLogging.IsImported(product);
            ConsoleLogging.IsTaxable(product);

            GroceryList.Add(product);
        }

        public static decimal CalculateTotal()
        {
            Total = SubTotal;
            foreach (var item in GroceryList)
            {
                if (item.TaxExcempt == false)
                {
                    SalesTaxTotal += Taxes.AddSalesTax(item.Price * item.Quantity);
                }
                if (item.Imported == true)
                {
                    ImportTaxTotal += Taxes.AddImportTax(item.Price * item.Quantity);
                }
            }
            return Total += SalesTaxTotal + ImportTaxTotal;
        }
    }
}