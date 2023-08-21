using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondSoln.Model
{
    internal class Animal : ICarnivore, IHerbivore
    {
        void ICarnivore.HuntingSkills()
        {
            Console.WriteLine("Carnivorous Animal have good hunting skills");
        }
        
        void IHerbivore.HuntingSkills()
        {
            Console.WriteLine("Herbivorous Animal don't have hunting skills");
        }
       
      
    } 
}
