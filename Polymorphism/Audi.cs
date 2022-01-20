using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }
        public Audi()
        {

        }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }
        public new void ShowDetails()
        {
            Console.WriteLine("Brand: {0}", brand);
            Console.WriteLine("HP: {0}", HP);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Model: {0}", Model);
        }
        public override void Repair()
        {
            Console.WriteLine("The {0} {1} was repaired", brand, Model);
        }


    }
}
