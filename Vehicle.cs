using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_in_CSharp
{
    class Vehicle : IVehicle
    {
        public string RegNo { get; set; }

        public void Drive()
        {
            Console.WriteLine("Vehicle starts driving.");

        }
    }
}
