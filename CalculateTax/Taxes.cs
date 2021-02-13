using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateTax
{
    class Taxes
    {
        public static decimal SalesTax { get; set; }
        public static decimal ImportTax { get; set; }


        public static decimal AddImportTax(decimal total)
        {
            ImportTax = total * .05m;
            return Math.Ceiling(ImportTax * 20) / 20;
        }

        public static decimal AddSalesTax(decimal total)
        {
            SalesTax = total * .1m;
            return Math.Ceiling(SalesTax * 20) / 20;
        }

        
    }
}
