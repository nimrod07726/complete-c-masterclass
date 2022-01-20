using System;

namespace OOP
{
    class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human()
        {
            Console.WriteLine("Constructor called. Object created.");
        }
        
        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public void IntroduceMyself()
        {
            if(age != 0 && firstName != null && lastName != null && eyeColor != null) 
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eye color is {3}.", firstName, lastName, age, eyeColor);
            else if (firstName == null)
                Console.WriteLine("Hi, I'm a generic human.");
            else if (age == 0 && eyeColor == null && lastName == null)
                Console.WriteLine("Hi, I'm {0}.", firstName);
            else if (age == 0 && eyeColor == null)
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            else if (age == 0 && eyeColor != null)
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}.", firstName, lastName, eyeColor);
            else if (age != 0 && eyeColor == null)
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old.", firstName, lastName, age);

        }

    }
}
