using System;
using System.Text;

namespace Part2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Skynet";
            Console.WriteLine("Моей темой является \"Морг\", в качестве абстрактного класса я решил сделать морг, от которого наследуются классы:\n1) Морг для взрослых\n2) Морг для детей\n3) Морг для животных\n");

            AdultMorgue adultMorgue = new AdultMorgue
            {
                Location = "Kazan",
                NumberOfCorpses = 235,
                NumberOfCeels = 410,
                YearOfConstruction = 1990,
                NumberOfCryingHusbands = 15,
                NumberOfCryingWifes = 100
            };
            adultMorgue.PrintType();
            adultMorgue.PrintInfoAboutMorgue();
            adultMorgue.PrintAgeOfMorgue(2023);
            adultMorgue.PrintNumberOfFreeCeels();
            adultMorgue.Enter();
            adultMorgue.PrintInfoAboutSadPeople();
            adultMorgue.SeeAutopsy();
            adultMorgue.Exit();

            ChildrenMorgue childrenMorgue = new ChildrenMorgue
            {
                Location = "Kazan",
                NumberOfCorpses = 142,
                NumberOfCeels = 372,
                YearOfConstruction = 1954,
                NumberOfCryingMothers = 15,
                NumberOfCryingDads = 5
            };
            childrenMorgue.PrintType();
            childrenMorgue.PrintInfoAboutMorgue();
            childrenMorgue.PrintAgeOfMorgue(2023);
            childrenMorgue.PrintNumberOfFreeCeels();
            childrenMorgue.Enter();
            childrenMorgue.PrintInfoAboutSadPeople();
            childrenMorgue.SeeAutopsy();
            childrenMorgue.Exit();

            AnimalMorgue animalMorgue = new AnimalMorgue
            {
                Location = "Kazan",
                NumberOfCorpses = 52,
                NumberOfCeels = 120,
                YearOfConstruction = 2010,
                NumberOfCryingOwners = 30,
                NumberOfVets = 10
            };
            animalMorgue.PrintType();
            animalMorgue.PrintInfoAboutMorgue();
            animalMorgue.PrintAgeOfMorgue(2023);
            animalMorgue.PrintNumberOfFreeCeels();
            animalMorgue.Enter();
            animalMorgue.PrintInfoAboutSadPeople();
            animalMorgue.SeeAutopsy();
            animalMorgue.Exit();

            Console.ReadKey();
        }
    }
}
