using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Model
{
    internal interface IVehicleDetails
    {
        void VehicleModel(string model);
        void VehicleName(string name);
        void VehicleNumber(string number);
    }
}
