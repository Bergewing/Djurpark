using System;
using Djurpark;

//4.Skapa en klass för lejon. Kalla klassen Lion. Lion-klassen ska ärva från Animal. Tänk på 
//att du måste anropa konstruktorn i Animal-klassen för att koden ska fungera. 

//5. Skapa en klass för Zebra. Kalla klassen Zebra. Zebra-klassen ska också ärva från 
//Animal. Tänk på att du måste anropa konstruktorn i Animal-klassen för att koden ska 
//fungera. 

//Jag är här

//6. Skapa en klass som heter Zoo. Klassen ska ha ett private -fält som är lista med djur. Skriv 
//också en publik konstruktor som skapar djur-listan och sparar den i fältet. Lägg till hur många 
//lejon och zebror du vill men minst en av varje sort. 

//7. Skapa en publik metod i Zoo-klassen. Metoden ska heta FeedAllAnimals. Feed tar en 
//string-parameter som förväntas innehåll namnet på något djur kan äta. Metoden ska loopa 

//Eller här.

//Fråga varför och när man använder void kontra return
Zoo Zebra1 = new Zoo();

Zebra1._animals.Add(new Zebra());
Zebra1._animals.Add(new Lion());

var djur = Zebra1._animals;

foreach (var item in djur)
{
    Console.WriteLine(item);
}

Zebra1.FeedAllAnimals("Papper");