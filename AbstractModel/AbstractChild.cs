using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo.Model
{
    internal class AbstractChild:AbstractParent
    {
        public override void Multiplication(int x,int y)
        {
            Console.WriteLine($"Product is: {x * y}");
        }
        public override void Divide(int x,int y)
        {
            Console.WriteLine($"Division is: {x / y}");
        }
    }
}
