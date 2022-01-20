using System;

namespace OOPProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);
            Console.WriteLine("Box width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("Box width is " + box.Width);
            Console.WriteLine("Box volume is " + box.Volume);
            Console.WriteLine("Box front surface is " + box.FrontSurface);
            box.DisplayInfo();

            Console.Read();
        }
    }
}
