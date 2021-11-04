using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    abstract class Animal
    {
        public int NumOfLegs { get;}
        public string _name;

        protected Animal(string name)
        {
            _name = name;
        }

        public virtual void Feed(Food food)                             //Kolla om man kan köra denna
        {                                                               //string istället för void
            Console.WriteLine($"The {_name} is eating {food}");

        }

        public virtual string Pet(string name)
        {
            return $"{AnimalType()}{name} was petted";
        }

        public abstract string AnimalType();

    }
}
