using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Sphere : Shape
    {
        public double Radius { get; set; }
        private const double PI = 3.1415926;

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }

        public override double Volume()
        {
            return 4 * PI * Math.Pow(Radius, 3) / 3;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Sphere has a radius of {Radius}.");
        }
    }
}
