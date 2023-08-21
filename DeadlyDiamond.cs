using DeadlyDiamondSoln.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondSoln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            ((ICarnivore)animal).HuntingSkills();
            ((IHerbivore)animal).HuntingSkills();
        }
    }
}
