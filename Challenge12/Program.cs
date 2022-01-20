using System;

namespace Challenge12
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Boss boss = new Boss();
            Trainee trainee = new Trainee("Warhol", "Andy", 40000, 20, 20);

            boss.Lead();

            trainee.Work();
            
            Console.ReadKey();

        }
    }
}
