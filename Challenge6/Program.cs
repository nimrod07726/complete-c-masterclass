using System;

namespace Challenge6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a temperature value (C°): ");
            string inputTemperature = Console.ReadLine();
            int intTemperature;

            bool isInteger = int.TryParse(inputTemperature, out intTemperature);

            string outString;
            
            outString = isInteger ? Process(intTemperature) : "Input value is not a valid temperature!";

            Console.WriteLine(outString);
            Console.Read();
        }

        private static string Process(int temperature)
        {
            string output;

            output = temperature <= 15 ? "it is too cold here" : temperature >= 16 && temperature <= 28 ? "it is ok" :
                "it is not here";

            return output;
        }
    }
}
