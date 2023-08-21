using AbstractClassDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractChild operation = new AbstractChild();
            AbstractParent parent = operation;

            parent.Add(10, 100);
            parent.Sub(100, 10);
            parent.Multiplication(10, 100);
            parent.Divide(100, 5);
        }
    }
}
