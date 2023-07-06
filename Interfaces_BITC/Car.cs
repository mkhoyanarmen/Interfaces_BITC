using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_BITC
{
    internal class Car : IVehicle
    {
        private int Gasoline { get; set; }
        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("Car is Driving");
            }
        }

        public bool Refuel(int gasoline)
        {
            Gasoline = gasoline;
            return true;
        }
    }
}
