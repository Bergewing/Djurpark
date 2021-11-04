using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Zebra : Herbivore
    {

        public Zebra(string name) : base(name)
        {

        }

        public override string AnimalType()
        {
            return "Zebra";
        }
    }
}
