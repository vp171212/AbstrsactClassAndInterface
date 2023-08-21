using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Model
{
    internal interface IVehicle
    {
        void ChangeGear(int gearNum);
        void SpeedUp(int increment);
        void ApplyBrakes(int breaks);
    }
}
