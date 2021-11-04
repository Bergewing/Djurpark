using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Herbivore : Animal
    {
        public Herbivore(string name) : base(name)
        {

        }

        public override void Feed(Food food)
        {
            Console.WriteLine($"The {AnimalType()} {_name} is eating {food}");

            if (food == Food.Beef || food == Food.Meat)
            {
                Console.WriteLine($"{_name} got sick of your fucking shit");
            }
        }

        public override string AnimalType()
        {
            return $"{AnimalType()}{_name} was petted";
        }
    }
}
