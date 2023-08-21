using InterfaceDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            Console.WriteLine("================Bicycle=============");
            bicycle.VehicleModel("2019M");
            bicycle.VehicleName("Hero");
            bicycle.VehicleNumber("HN123");
            bicycle.ChangeGear(3);
            bicycle.ApplyBrakes(2);
            bicycle.SpeedUp(7);
            Console.WriteLine("================Bike=============");
            Bike bike = new Bike();
            bike.VehicleModel("2019M");
            bike.VehicleName("R15");
            bike.VehicleNumber("KL0VP123");
        }
    }
}
