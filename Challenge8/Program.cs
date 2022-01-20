using System;

namespace Challenge8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type some input data: ");
            string inputData = Console.ReadLine();

            Console.WriteLine("What is the data type? :");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for integer");
            Console.WriteLine("Press 3 for Boolean");

            string inputDataType = Console.ReadLine();
            bool matchesDataType = false;

            switch (inputDataType)
            {
                case "1":
                    inputDataType = "String";
                    matchesDataType = IsString(inputData);  
                    break;
                case "2":
                    inputDataType = "Integer";
                    matchesDataType = IsInteger(inputData);
                    break;
                case "3":
                    inputDataType = "Boolean";
                    matchesDataType = IsBoolean(inputData);
                    break;
                default:
                    break;
            }

            Console.WriteLine("You have entered some input data: {0}", inputData);

            if(matchesDataType) Console.WriteLine("It is a valid: {0}", inputDataType);
            else Console.WriteLine("It is an invalid: {0}", inputDataType);

            Console.Read();

        }

        static bool IsString(string input)
        {
            foreach(char character in input)
            {
                if (character >= 48 && character <= 57) return false;
            }

            return true;
        }

        static bool IsInteger(string input)
        {
            int integer;
            return int.TryParse(input, out integer);
        }

        static bool IsBoolean(string input)
        {
            bool boolean;
            return bool.TryParse(input, out boolean);
        }
    }
}
