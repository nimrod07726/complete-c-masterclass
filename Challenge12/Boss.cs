using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge12
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss()
        {

        }
        public Boss(string name, string firstName, int salary, string companyCar) : base(name, firstName, salary)
        {
            CompanyCar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine("I'm leading.");
        }
    }
}
