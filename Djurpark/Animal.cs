using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Animal
    {
        private int _numOfLegs;

        public int NumberOfLegs{ get{ return _numOfLegs; }}

        protected Animal()
        {
            _numOfLegs = 4;
        }

        public void Feed(string food)                           //Kolla om man kan köra denna
        {                                                       //string istället för void
            Console.WriteLine($"The animal is eating {food}");  

        }

    }
}
