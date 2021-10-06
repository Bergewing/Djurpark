using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Zoo : Animal
    {
        public List<Animal> _animals;       //Denna ska egentligen vara private
                                            //Men för att kunna lägga till mer via program måste den vara public
        public Zoo()                            //Kolla om man kan lägga till enstaka djur
        {                                       //i listan via program istället för ett set
            Animal zebra = new Zebra();         //med djur från konstruktorn
            Animal lion = new Lion();
            _animals = new List<Animal>() {zebra, lion};
        }

        public void FeedAllAnimals(string food)         //Kolla om man kan köra denna
        {                                               //string istället för void
            for (int i = 0; i < _animals.Count; i++)
            {
                _animals[i].Feed(food);
            }
        }
    }
}
