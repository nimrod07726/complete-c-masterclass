using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge12
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }
        public Trainee()
        {

        }
        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours) : base(name, firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {

        }

        public override void Work()
        {
            Console.WriteLine("The trainee's {0} working hours are {1}.", Name, WorkingHours);
        }
    }
}
