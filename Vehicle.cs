using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_in_CSharp
{
    class Vehicle : IVehicle
    {
        public Vehicle(string regNo)
        {
            RegNo = regNo;
        }
        public string RegNo { get; set; }

        public virtual string Drive()
        {
            return "Vehicle starts driving";
        }
    }

    class Bicycle : Vehicle
    {
        public Bicycle (string frameNumber) : base(frameNumber)
        {

        }
        public override string Drive()
        {
            return base.Drive() + ", bicycle starts pedaling."; 
        }
    }
}
