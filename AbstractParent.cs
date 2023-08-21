using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo.Model
{
    abstract class AbstractParent
    {
        public virtual void Add(int num1, int num2) 
        {
            Console.WriteLine($"Sum is: {num1 + num2}");
        }
        public virtual void Sub(int num1, int num2)
        {
            Console.WriteLine($"Difference is: {num1 - num2}");
        }
        public abstract void Multiplication(int num1, int num2);
        public abstract void Divide(int num1, int num2);    
    }
}
