using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_BITC
{
    internal interface IVehicle
    {
        void Drive();
        bool Refuel(int gasoline);
    }
}
