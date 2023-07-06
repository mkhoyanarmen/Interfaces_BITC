using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2_BITC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "Raffu Samvel";
            book.Price = 2500;
            Console.WriteLine("Book`s Shipping Fee: " + book.CalculateShippingFee());

            Electronics washingMachine = new Electronics();
            washingMachine.Name = "LG";
            washingMachine.Price = 255000;
            Console.WriteLine("Washing Machine`s Shipping Fee: " + washingMachine.CalculateShippingFee());

        }
    }
}
