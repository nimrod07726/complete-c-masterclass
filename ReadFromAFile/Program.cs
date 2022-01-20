using System;
using System.IO;

namespace ReadFromAFile
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Reading
            //string text = System.IO.File.ReadAllText(@"C:\Users\dilop\source\repos\HelloWorld\ReadFromAFile\textFile.txt");
            //Console.WriteLine("TExtfile contains the following text: {0}", text);

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\dilop\source\repos\HelloWorld\ReadFromAFile\textFile.txt");

            //Console.WriteLine("Contents of textfile.txt = ");

            //foreach (string line in lines)
            //{
            //    Console.WriteLine("\t" + line);
            //}

            // 2. Writing


            // Method 1
            string[] highScores = { "1337", "420", "6969" };
            string[] lines = { "1337", "420", "Third 6969" };

            File.WriteAllLines(@"C:\Users\dilop\source\repos\HelloWorld\ReadFromAFile\highscores.txt", highScores);

            // MEthod 2

            //Console.WriteLine("Please give the file name");
            //string fileName = Console.ReadLine();
            //Console.WriteLine("Please enter the text for the file");
            //string input = Console.ReadLine();

            //File.WriteAllText(@"C:\Users\dilop\source\repos\HelloWorld\ReadFromAFile\" + fileName + ".txt", input);

            // Method 3

            using(StreamWriter file = new StreamWriter(@"C:\Users\dilop\source\repos\HelloWorld\ReadFromAFile\myText.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("3"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"C:\Users\dilop\source\repos\HelloWorld\ReadFromAFile\myText.txt", true))
            {
                file.WriteLine("Additional line");
            }

            Console.ReadKey();
        }
    }
}
