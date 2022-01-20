using System;
using System.Collections;

namespace Challenge11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsTable = new Hashtable();

            foreach(Student student in students)
            {
                if (studentsTable.ContainsKey(student.Id))
                    Console.WriteLine("Sorry, a student with the same ID already exists ID:{0}", student.Id);
                else
                {
                    studentsTable.Add(student.Id, student);
                    Console.WriteLine("Student with ID {0} was added!", student.Id);
                }
                    
            }

            Console.Read();

        }
    }
}
