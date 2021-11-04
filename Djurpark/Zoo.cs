using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Zoo : Animal
    {
        private List<Animal> _listOfAnimals;

        public Zoo(string name) : base (name)                                                  
        {
            _listOfAnimals = new List<Animal>() { new Zebra("Sebra"), new Lion("Leo"), new Zebra("Sedermera"), new Lion("Annat") };
        }

        public void FeedAllAnimals(Food food)
        {                                               
            for (int i = 0; i < _listOfAnimals.Count; i++)
            {
                _listOfAnimals[i].Feed(food);
            }
        }

        public void ListOfAnimals()
        {
            for (int i = 0; i < _listOfAnimals.Count; i++)
            {
                Console.WriteLine($"{_listOfAnimals[i].GetType(), -20} {_listOfAnimals[i]._name}");
            }
        }

        public void ListOfHerbivores()
        {
            for (int i = 0; i < _listOfAnimals.Count; i++)
            {
                if (_listOfAnimals[i] is Herbivore)
                {
                    Console.WriteLine($"{_listOfAnimals[i].GetType(),-20} {_listOfAnimals[i]._name}");
                }
            }
        }

        public void PetAnimal(string name)
        {
            Pet(name);
        }

        public override string AnimalType()
        {
            return "";
        }

    }
}



/*3. Skapa en metod i Zoo-klassen som heter PetAnimal. PetAnimal tar in en string-parameter som förväntas vara namnet på ett av djuren.
 * I metoden ska vi loopa över alla djur och leta efter ett som matchar namnet vi skickade in. 
 * Om vi inte hittar namnet i listan av djur ska PetAnimal-metoden skriva ut ”No animal by that name”.
 * Om vi hittar ett djur med rätt namn anropar vi dess Pet-metod. Kom ihåg att Carnivore-klassen förhindrar att vi råkar klappa ett rovdjur.

4. I Program.cs, anropa PetAnimal-metoden i Zoo-klassen med olika djurnamn. 
Prova att använda ett namn som inte finns, ett namn som är en köttätare och ett namn som är en växtätare.*/
