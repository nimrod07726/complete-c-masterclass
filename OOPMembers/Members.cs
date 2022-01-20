using System;
using System.Diagnostics;

namespace OOPMembers
{
    class Members
    {
        // member private field
        private string memberName;
        private string jobTitle;
        private int salary;

        public int age;

        public string JobTitle {
            get {
                return jobTitle;
            }
            set {
                jobTitle = value;
            }
        }

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is: {0}", salary);
        }

        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // finalizer - destructor

        ~Members()
        {
            Debug.Write("Destruction of Members Object");
        }
            
    }
}
