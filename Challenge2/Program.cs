using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 0;
            sbyte mySByte = -1;
            int myInt = -255;
            uint myUInt = 255;
            short myShort = -123;
            ushort myUShort = 123;
            long myLong = -1234567890123456789;
            ulong myULong = 1234567890123456789;
            float myFloat = 123.456f;
            double myDouble = 321.654;
            char myChar = 'a';
            bool myBool = false;

            string myString1 = "I control text";
            string myString2 = "12456";
            int parsedWholeNumber = int.Parse(myString2);

            Console.WriteLine(myByte);
            Console.WriteLine(mySByte);
            Console.WriteLine(myInt);
            Console.WriteLine(myUInt);
            Console.WriteLine(myShort);
            Console.WriteLine(myUShort);
            Console.WriteLine(myLong);
            Console.WriteLine(myULong);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myChar);
            Console.WriteLine(myBool);
            Console.WriteLine(myString1);
            Console.WriteLine(myString2);
            Console.WriteLine(parsedWholeNumber);

            Console.Read();
        }
    }
}
