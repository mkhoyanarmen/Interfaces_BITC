﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_BITC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Refuel(10);
            car.Drive();
        }
    }
}
