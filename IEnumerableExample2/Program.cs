using System;
using System.Collections.Generic;

namespace IEnumerableExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };

            Console.WriteLine();

            CollectionSum(numberList);

            Console.WriteLine();

            CollectionSum(numberArray);

            Console.ReadKey();
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum += num;
            }

            Console.Write("Sum is {0}", sum);
        }
    }
}
