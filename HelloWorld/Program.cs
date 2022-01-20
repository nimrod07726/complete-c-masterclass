using System;

namespace HelloWorld
{
    // Class names like ClassName
    // Use nouns for classes
    class Program
    {
        // Methods name like MethodName
        // Method arguments like firstNumber
        // Use verbs
        static void Main(string[] args)
        {
            // local variables like itemCount

            // use userControl (not abbrv lie usrCtrl)

            // no numbers at the start of variables
            // underscores at the beginning not at the end

            //double myDouble = 13.37;
            //int myInt;

            //// implicit conversion
            //int num = 12345678;
            //long bigNum = num;

            //float myFloat = 13.37f;
            //double myNewDouble = myFloat;


            //// explicit conversion
            //// cast double to int

            //myInt = (int)myDouble;


            //// type conversion

            ////string myString = myDouble.ToString();
            //num.ToString();
            //bigNum.ToString();
            //string myStringFloat = myFloat.ToString();
            //bool sunIsShining = true;

            //string byBoolString = sunIsShining.ToString();

            ////////////////////////////////////////////////////////////////////

            //string myString = "15";
            //string mySecondString = "13";
            //int num1 = Int32.Parse(myString);
            //double.Parse(myString);
            //int num2 = Int32.Parse(mySecondString);
            //int result = num1 + num2;


            //Console.WriteLine(result);
            //Console.Read();

            ////////////////////////////////////////////////////////////////////

            //int age = 28;
            //string name = "Diego";
            //string job = "Developer";

            //Console.WriteLine("String concatenation");
            //Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");

            //Console.WriteLine("String Formatting");
            //Console.WriteLine("Hello my name is {0}, I am {1} years old and I am a {2}", name, age, job);

            //Console.WriteLine("String Interpolation");
            //Console.WriteLine($"Hello my name is {name}, I am {age} years old and I am a {job}");

            //Console.WriteLine("Verbatim strings");
            //Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
            //incididunt ut labore et dolore magna aliqua. Elementum tempus egestas sed sed. Massa sapien faucibus et molestie.
            //Egestas erat imperdiet sed euismod nisi porta. Semper eget duis at tellus at urna condimentum mattis pellentesque
            //Egestas maecenas pharetra convallis posuere morbi leo urna. Sit amet dictum sit amet justo donec enim diam.
            //Nam at lectus urna duis convallis convallis. Lacus vel facilisis volutpat est velit egestas dui id.
            //Sed arcu non odio euismod lacinia at quis risus sed. Venenatis lectus magna fringilla urna.
            //Ultricies mi quis hendrerit dolor magna.");

            //Console.WriteLine(@"C:\User\Directory\SubDirectory\File.ext");

            //Console.Read();

            ////////////////////////////////////////////////////////////////////

            //string firstName = "Denis";
            //string lastName = "Panjuta";
            //string fullName = string.Concat(" ", firstName, lastName, " ");

            //Console.WriteLine(fullName.Trim());
            //Console.WriteLine(string.Format("His name is {0} {1}", firstName, lastName));
            //Console.Read();

            ////////////////////////////////////////////////////////////////////

            //string myString = string.Empty;

            //Console.WriteLine("Please enter your name and press Enter:");
            //myString = Console.ReadLine();

            //string myNameUpperCase = string.Format("Upper case: {0}", myString.ToUpper());
            //Console.WriteLine(myNameUpperCase);
            //string myNameLowerCase = string.Format("Lower case: {0}", myString.ToLower());
            //Console.WriteLine(myNameLowerCase);
            //string myNameTrimmed = string.Format("Trimmed: {0}", myString.Trim());
            //Console.WriteLine(myNameTrimmed);
            //string myNameSubString = string.Format("Substring: {0}", myString.Substring(5, 3));
            //Console.WriteLine(myNameSubString);
            //Console.Read();

            ////////////////////////////////////////////////////////////////////

            Console.WriteLine("Enter a string here: ");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter a character to search in the string: ");
            char characterToSearch = Console.ReadLine()[0];

            int index = firstString.IndexOf(characterToSearch);

            Console.WriteLine("Index: {0}", index);

            Console.WriteLine("Enter the first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name; ");
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);
            Console.Read();

        }

    }
}
