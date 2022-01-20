using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };

            //double averageResult = GetAverage(studentsGrades);

            //foreach(int grade in studentsGrades)
            //{
            //    Console.WriteLine(" {0} ", grade);
            //}

            //Console.WriteLine("The average is: {0}", averageResult);

            int[] happiness = new int[] { 5, 3, 7, 8, 9 };

            SunIsShining(happiness);

            foreach(int value in happiness)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }

        static void SunIsShining(int[] happiness)
        {
            for(int i = 0; i < happiness.Length; i++)
            {
                happiness[i]+=2;
            }
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;

            return average;
        }
    }
}
