using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            //alt way
            int[][] jaggedArray2 = new int[][]
            {
                new int[]{1,2,3,4,5},
                new int[]{1,2,3}
            };

            Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray2[0][2]);

            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                for(int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write("{0} ", jaggedArray[i][j]);
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
