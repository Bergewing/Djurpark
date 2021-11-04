using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    abstract class Carnivore : Animal
    {

        public Carnivore(string name) : base(name)
        {

        }

        public override void Feed(Food food)
        {
            Console.WriteLine($"The {AnimalType()} {_name} is eating {food}");

            if (food == Food.Carrot || food == Food.Grass)
            {
                Console.WriteLine($"{_name} didn't like your shit food");
            }
        }

        public override string Pet(string name)
        {
            return "You're not allowed to pet carnivores";
        }
    }
}
