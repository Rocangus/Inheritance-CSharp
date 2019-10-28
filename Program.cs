using System;

namespace Inheritance_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("ABC121");
            Vehicle bike = new Bicycle("BBB333zGH33");
            var regNo = vehicle.RegNo;

            Console.WriteLine(vehicle.Drive());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(bike.Drive());
        }
    }
}
