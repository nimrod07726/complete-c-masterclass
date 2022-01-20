using System;

namespace Challenge10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] familyMembers = new string[][]
            {
                new string[] {"Carlos", "Martha", "Adriana"},
                new string[] {"Nicolas", "Gloria", "Diego"},
                new string[] {"Andres", "Juan", "Alexandra"}
            };

            Console.WriteLine("{0} and {1}, let me introduce you to {2} and {3}",
                familyMembers[0][1], familyMembers[0][2],
                familyMembers[1][1], familyMembers[1][2]);

            Console.WriteLine("{0} and {1}, let me introduce you to {2} and {3}",
                familyMembers[0][1], familyMembers[0][2],
                familyMembers[2][1], familyMembers[2][2]);

            Console.WriteLine("{0} and {1}, let me introduce you to {2} and {3}",
                familyMembers[1][1], familyMembers[1][2],
                familyMembers[2][1], familyMembers[2][2]);

            Console.ReadKey();
        }
    }
}
