using System;

namespace Part2
{
    class AdultMorgue : Morgue
    {
        protected int numberOfCryingWifes {get;set;}
        protected int numberOfCryingHusbands { get;set;}

        public AdultMorgue()
        {
            numberOfCryingWifes = 0;
            numberOfCryingHusbands = 0;
        }

        public enum AverageLevelOfCorpseDecompostition
        {
            Свежие,
            Вздутые_животы,
            Активное_разложение,
            Прогрессирующее_разложение,
            Сухие_останки
        }
        public int NumberOfCryingWifes
        {
            get { return numberOfCryingWifes; }
            set { numberOfCryingWifes = value; }
        }
        public int NumberOfCryingHusbands
        {
            get { return numberOfCryingHusbands; }
            set { numberOfCryingHusbands = value; }
        }
        public void PrintType()
        {
            Console.WriteLine("Тип морга: Морг для взрослых");
        }
        public override void Enter()
        {
            Console.WriteLine("Вы волшли в морг для взрослых");
        }
        public override void Exit()
        {
            Console.WriteLine("Вы вышли из морга для взрослых\n");
        }
        public override void SeeAutopsy()
        {
            Console.WriteLine("Вы увидели вскрытие трупа взрослого человека");
        }
        public override void PrintInfoAboutSadPeople()
        {
            Console.WriteLine($"В морге плачет {numberOfCryingWifes} жён и {numberOfCryingHusbands} мужей");
        }
    }
}
