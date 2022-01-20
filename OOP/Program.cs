using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human max = new Human("Max", "Verstappen", "blue", 24);
            max.IntroduceMyself();

            Human michael = new Human("Michael", "Schumacher", "green", 52);
            michael.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human walter = new Human("Walter", "White");
            walter.IntroduceMyself();

            Human diego = new Human("Diego", "Lopez", 28);
            diego.IntroduceMyself();

            Console.Read();
        }
    }
}
