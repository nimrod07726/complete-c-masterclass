using System;

namespace Challenge7
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double currentScore;
            double sumOfScores = 0;
            bool isDouble;

            while (true)
            {
                Console.Write("Input a score: ");
                isDouble = double.TryParse(Console.ReadLine(), out currentScore);

                if (isDouble && (currentScore >= 0 && currentScore <= 20 || currentScore == -1))
                {
                    if (currentScore == -1) break;
                    sumOfScores += currentScore;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalid score value!");
                }
            }

            double average = counter == 0 ? 0 : sumOfScores / counter;

            Console.WriteLine("The average of scores is equal to {0}", average);

            Console.Read();
        }
    }
}
