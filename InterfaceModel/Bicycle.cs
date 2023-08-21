using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Model
{
    internal class Bicycle:IVehicleDetails,IVehicle
    {
        int speed=10;
        public void ChangeGear(int gearNum)
        {
            Console.WriteLine("Gear is Changed to: " + gearNum);
        }
        public void SpeedUp(int increment)
        {
            speed = speed + increment;
            Console.WriteLine($"Current increased speed is: {speed} " );  
        }
        public void ApplyBrakes(int breaks)
        {
            speed = speed - breaks;
            Console.WriteLine($"Current decreased speed is: {speed} ");
        }
        public void VehicleModel(string model)
        {
            Console.WriteLine($"Bicycle model is: {model}");
        }
        public void VehicleName(string name)
        {
            Console.WriteLine($"Bicycle name is: {name}");
        }
        public void VehicleNumber(string number)
        {
           Console.WriteLine($"Bicycle number is: {number}");
        }
    }
}
