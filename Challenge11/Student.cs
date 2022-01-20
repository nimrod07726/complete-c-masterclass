using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge11
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public Student(int id, string name, float GPA)
        {
            Id = id;
            Name = name;
            this.GPA = GPA;
        }
    }
}
