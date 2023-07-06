using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2_BITC
{
    internal interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
        decimal CalculateShippingFee();
    }
}
