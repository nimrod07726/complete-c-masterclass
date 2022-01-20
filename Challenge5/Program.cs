using System;

namespace Challenge5
{
    class Program
    {
        static int highscore = 1000;
        static string highscorePlayer = "Denis";

        static void Main(string[] args)
        {
            int score;
            string player;

            Console.WriteLine("New player: ");
            player = Console.ReadLine();

            Console.WriteLine("New score: ");
            score = int.Parse(Console.ReadLine());

            CheckScore(player, score);

            Console.Read();
        }

        private static void CheckScore(string playerName, int score)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not" +
                    " be beaten and is still held by " + highscorePlayer);
            }
        }
    }
}
