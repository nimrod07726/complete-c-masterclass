using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

            foreach(DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}", temp.Id);
                Console.WriteLine("Student Name:{0}", temp.Name);
                Console.WriteLine("Student GPA:{0}", temp.GPA);              
            }

            foreach(Student student in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0}", student.Id);
                Console.WriteLine("Student Name:{0}", student.Name);
                Console.WriteLine("Student GPA:{0}", student.GPA);
            }

            Console.ReadKey();
        }
    }

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
