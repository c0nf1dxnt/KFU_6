using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    abstract class Morgue
    {
        protected string location { get; set; }
        protected int numberOfCorpses { get; set; }
        protected int numberOfCeels { get; set; }
        protected int yearOfConstruction { get; set; }

        public Morgue()
        {
            location = "unspecified";
            numberOfCorpses = 0;
            numberOfCeels = 0;
            numberOfCorpses = 0;
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public int NumberOfCorpses
        {
            get { return numberOfCorpses; }
            set { numberOfCorpses = value; }
        }
        public int NumberOfCeels
        {
            get { return numberOfCeels; }
            set { numberOfCeels = value; }
        }
        public int YearOfConstruction
        {
            get { return yearOfConstruction; }
            set { yearOfConstruction = value; }
        }
        public abstract void Enter();
        public abstract void Exit();
        public abstract void SeeAutopsy();
        public abstract void PrintInfoAboutSadPeople();
        public void PrintInfoAboutMorgue()
        {
            Console.WriteLine($"Морг в городе {location} был построен в {YearOfConstruction} и имеет {numberOfCeels} ячеек и {numberOfCorpses} трупов в них.");
        }
        public void PrintAgeOfMorgue(int currentYear)
        {
            Console.WriteLine($"Морг был построен {currentYear - yearOfConstruction} лет назад.");
        }
        public void PrintNumberOfFreeCeels()
        {
            Console.WriteLine($"В морге {numberOfCeels - numberOfCorpses} свободных мест.");
        }
    }
}
