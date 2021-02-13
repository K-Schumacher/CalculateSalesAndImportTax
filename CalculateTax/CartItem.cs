using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateTax
{
    public class CartItem
    {
        public CartItem()
        {

        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool Imported { get; set; }
        public bool TaxExcempt { get; set; }
    }
}
