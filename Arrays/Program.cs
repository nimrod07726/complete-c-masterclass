using System;

namespace Arrays
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] grades = new int[5];

        //    grades[0] = 20;
        //    grades[1] = 15;
        //    grades[2] = 12;
        //    grades[3] = 9;
        //    grades[4] = 7;


        //    Console.WriteLine("grades at index 0: {0}", grades[0]);
            
        //    string input = Console.ReadLine();
        //    // assign value to array at index 0
        //    grades[0] = int.Parse(input);

        //    Console.WriteLine("grades at index 0: {0}", grades[0]);

        //    int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };
        //    int[] gradesOfMathStudentsB = new int[] { 20, 15, 12, 8, 8};

        //    Console.WriteLine("amount of grades of math students A: {0}"  , gradesOfMathStudentsA.Length); 
            
        //    Console.Read();


        //}

        static void Main(string[] args)
        {
            string[,] matrix;

            int[,,] threeD;

            int[,] array2D = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            Console.WriteLine("central value is: {0}", array2D[1, 1]);
            Console.WriteLine("Value at (2,0) is: {0}", array2D[2, 0]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" },
                    {"Hi there", "What's up?" }
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Another one", "Last entry" }
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                { "one", "two"},
                { "three", "four"},
                { "five", "six"}
            };

            array2DString[1, 1] = "chicken";

            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("the value is: {0}", dimensions);



            Console.Read();
        }
    }
}
