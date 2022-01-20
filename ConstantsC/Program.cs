using System;

namespace ConstantsC
{
    class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string birthDate = "01/13/1993";


        static void Main(string[] args)
        {
            Console.WriteLine("My birthday will always be at: {0}", birthDate);
            Console.Read();
        }
    }
}
