using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = MinV2(6, 4, 2, 8, 0, 1, 5, -11);
            Console.WriteLine("The minimum is: {0} ", min);
            Console.ReadKey();
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for(int i=0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach(object obj in stuff)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        public static int MinV2(params int [] numbers)
        {
            int min = int.MaxValue;

            foreach(int number in numbers)
            {
                if (number < min)
                    min = number;
            }
            return min;
        }

    }
}
