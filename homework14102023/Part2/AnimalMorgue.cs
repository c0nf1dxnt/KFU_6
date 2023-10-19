using System;

namespace Part2
{
    class AnimalMorgue : Morgue
    {
        protected int numberOfCryingOwners { get; set; }
        protected int numberOfVets { get; set; }

        public AnimalMorgue()
        {
            numberOfCryingOwners = 0;
            numberOfVets = 0;
        }
        public int NumberOfCryingOwners
        {
            get { return numberOfCryingOwners; }
            set { numberOfCryingOwners = value; }
        }
        public int NumberOfVets
        {
            get { return numberOfVets; }
            set { numberOfVets = value; }
        }
        public void PrintType()
        {
            Console.WriteLine("Тип морга: Морг для животных");
        }
        public override void Enter()
        {
            Console.WriteLine("Вы вошли в морг животных");
        }
        public override void Exit()
        {
            Console.WriteLine("Вы вышли из морга для животных\n");
        }
        public override void SeeAutopsy()
        {
            Console.WriteLine("Вы увидели вскрытие трупа животного");
        }
        public override void PrintInfoAboutSadPeople()
        {
            Console.WriteLine($"В морге плачет {numberOfCryingOwners} хозяев животных, а {numberOfVets} грустно выполняют свою работу");
        }
    }
}
