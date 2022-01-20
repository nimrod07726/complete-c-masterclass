using System;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            string friendName1 = "Mark";
            string friendName2 = "Tom";
            string friendName3 = "Travis";

            GreetFriend(friendName1);
            GreetFriend(friendName2);
            GreetFriend(friendName3);

            Console.Read();
        }

        private static void GreetFriend(string friendName)
        {
            Console.WriteLine(string.Format("Hi {0}, my friend!", friendName));
        }
    }
}
