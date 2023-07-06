using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2_BITC
{
    internal class Book : IProduct
    {
        public string Name { get; set; }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    price = 1;
                }
            }
        }

        public decimal CalculateShippingFee()
        {
            if (Price < 3000)
            {
                return Price * (decimal)0.1;
            }
            return 0;
        }
    }
}
