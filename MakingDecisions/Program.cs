using System;

namespace MakingDecisions
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("What is the temperature out there? : ");
        //    string temperature = Console.ReadLine();
        //    int numTemp;
        //    int number;
        //    bool userEnteredANumber = int.TryParse(temperature, out number);

        //    if (userEnteredANumber)
        //    {
        //        numTemp = number;
        //    }
        //    else
        //    {
        //        numTemp = 0;
        //        Console.WriteLine("Value entered not a number. ");
        //    }

        //    if (numTemp < 10)
        //    {
        //        Console.WriteLine("Take the coat");
        //    }
        //    else if (numTemp == 10)
        //    {
        //        Console.WriteLine("It's 10 degrees C");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Cozy & warm!");
        //    }

        //    Console.Read();
        //}
        /// ////////////////////////////////////////////////////////////

        //static void Main(string[] args)
        //{
        //    bool isAdmin = false;
        //    bool isRegistered = true;
        //    string userName;
        //    Console.WriteLine("Please enter your name: ");
        //    userName = Console.ReadLine();

        //    if (isRegistered && userName != "" && userName.Equals("admin"))
        //    {
        //        Console.WriteLine("Hi there, registered user");

        //            Console.WriteLine("Hi there, " + userName);

        //                Console.WriteLine("Hi there, Admin");
        //    }

        //    if (isAdmin || isRegistered)
        //    {
        //        Console.WriteLine("You are logged in!");
        //    }

        //    Console.Read();
        //}
        ////////////////////////////////////////////////////////////
        //static void Main(string[] args)
        //{
        //    int age = 25;

        //    //switch (age)
        //    //{
        //    //    case 15:
        //    //        Console.WriteLine("Too young to party in the club!");
        //    //        break;
        //    //    case 25:
        //    //        Console.WriteLine("Good to go!");
        //    //        break;
        //    //    default:
        //    //        Console.WriteLine("How old are you then?");
        //    //        break;
        //    //}

        //    if (age == 15) Console.WriteLine("Too young to party in the club!");
        //    else if (age == 25) Console.WriteLine("Good to go");
        //    else Console.WriteLine("How old are you then?");

        //    string username = "Diego";

        //    switch (username)
        //    {
        //        case "Diego":
        //            Console.WriteLine("Username is Diego");
        //            break;
        //        case "root":
        //            Console.WriteLine("Username is root");
        //            break;
        //        default:
        //            Console.WriteLine("username is unknown");
        //            break;
        //    }

        //    Console.Read();
        //}
        static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 30;
            
            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 100;

            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            Console.Read();
        }



    }
}
