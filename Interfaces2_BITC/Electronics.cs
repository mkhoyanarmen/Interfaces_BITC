using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2_BITC
{
    internal class Electronics : IProduct
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
                    price = 0;
                }
            }
        }


        public decimal CalculateShippingFee()
        {
            if (Price < 10000)
            {
                return Price * (decimal)0.2;
            }
            return 0;
        }
    }
}
