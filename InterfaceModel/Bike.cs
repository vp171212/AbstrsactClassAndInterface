using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Model
{
    internal class Bike:IVehicleDetails
    {
        public void VehicleModel(string model)
        {
            Console.WriteLine($"Bike model is: {model}");
        }
        public void VehicleName(string name)
        {
            Console.WriteLine($"Bike name is: {name}");
        }
        public void VehicleNumber(string number)
        {
            Console.WriteLine($"Bike number is: {number}");
        }
    }
}

