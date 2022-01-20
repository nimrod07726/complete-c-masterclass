using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolVal = new bool?();

            Console.WriteLine("Our nullable numbers are {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("The nullable boolean value is: ", boolVal);

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            } else if (isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }

            double? num5 = 13.1;
            double? num6;
            double? num7 = null;
            double num8;

            if(num5 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num5;
            }

            Console.WriteLine("Value of num8 is {0}", num8);

            num8 = num5 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);
            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);

            Console.ReadLine();
        }
    }
}
