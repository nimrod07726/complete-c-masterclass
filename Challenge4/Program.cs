using System;

namespace Challenge4
{
    class Program
    {

        static string registeredName;
        static string registeredPassword;
        static string loginName;
        static string loginPassword;

        static void Main(string[] args)
        {

            Register();
            Login();
            
            Console.Read();
        }

        private static void Register()
        {
            Console.WriteLine("Input a Name to register: ");
            registeredName = Console.ReadLine();

            Console.WriteLine("Input a Password to register: ");
            registeredPassword = Console.ReadLine();

            Console.WriteLine("Registration complete.");
        }

        private static void Login()
        {
            Console.WriteLine("Input your registered Name to login: ");
            loginName = Console.ReadLine();

            Console.WriteLine("Input your registered Password to login: ");
            loginPassword = Console.ReadLine();

            CheckCredentials();
        }

        private static void CheckCredentials()
        {
            if (registeredName == loginName && registeredPassword == loginPassword)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Login failed. Next time check your credentials.");
            }
        } 
    }
}
