using System;
using System.Text.RegularExpressions;

namespace RegexC
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d{5}";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";

            MatchCollection matchColection = regex.Matches(text);

            Console.WriteLine("{0} hits found:\n {1}", matchColection.Count, text);

            foreach (Match hit in matchColection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}",group[0].Value, group[0].Index);
            }
            
            Console.ReadKey();
        }
    }
}
