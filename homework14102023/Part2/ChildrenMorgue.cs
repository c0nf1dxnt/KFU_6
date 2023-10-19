using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class ChildrenMorgue : Morgue
    {
        protected int numberOfCryingMothers { get; set; }
        protected int numberOfCryingDads { get; set; }

        public ChildrenMorgue()
        {
            numberOfCryingMothers = 0;
            numberOfCryingDads = 0;
        }
        public int NumberOfCryingMothers
        {
            get { return numberOfCryingMothers; }
            set { numberOfCryingMothers = value; }
        }
        public int NumberOfCryingDads
        {
            get { return numberOfCryingDads; }
            set { numberOfCryingDads = value; }
        }
        public void PrintType()
        {
            Console.WriteLine("Тип морга: Морг для детей");
        }
        public override void Enter()
        {
            Console.WriteLine("Вы волшли в морг для детей");
        }
        public override void Exit()
        {
            Console.WriteLine("Вы вышли из морга для детей\n");
        }
        public override void SeeAutopsy()
        {
            Console.WriteLine("Вы увидели вскрытие трупа ребёнка");
        }
        public override void PrintInfoAboutSadPeople()
        {
            Console.WriteLine($"В морге плачет {numberOfCryingMothers} матерей и {numberOfCryingDads} отцов пытаются сдержать слёзы");
        }
    }
}
