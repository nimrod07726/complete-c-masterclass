using System;

namespace NestedForLoops
{
    class Program
    {

        static int[,] matrix =
        {
            { 1,2,3},
            { 4,5,6},
            { 7,8,9}
        };
        static void Main(string[] args)
        {
            //foreach(int item in matrix)
            //{
            //    Console.Write(item + " ");
            //}

            //// with nested loop

            //Console.WriteLine("\n with nested loop: ");

            //for(int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        if (i == j)
            //            matrix[i, j] = 1;
            //    }
            //}

            //for(int k = 0; k < matrix.GetLength(0); k++)
            //{
            //    matrix[k, k] = 2;
            //}

            //foreach (int item in matrix)
            //{
            //    Console.Write(item + " ");
            //}

            for(int m = 0; m < matrix.GetLength(0); m++)
            {
                Console.WriteLine(matrix[m, matrix.GetLength(0)- 1 - m]);
            }

            Console.Read();
        }

        
    }
}
