using System;

namespace Methods
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    WriteSomething();
        //    WriteSomethingSpecific("I am an argument and I am called from a method");
        //    Console.Read();
        //}

        //// access modifier (static) return type method name (parameter1, parameter2)
        //public static void WriteSomething()
        //{
        //    Console.WriteLine("I am called from a method");
        //}

        //public static void WriteSomethingSpecific(string myText)
        //{
        //    Console.WriteLine(myText);
        //}
        //////////////////////////////////////////////////////////////////////////////////
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
        //    Console.WriteLine(Multiply(2, 23));
        //    Console.WriteLine(Divide(25, 14));
        //    Console.Read();
        //}
        //public static int Add(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //public static int Multiply(int num1, int num2)
        //{
        //    return num1 * num2;
        //}

        //public static double Divide(double num1, double num2)
        //{
        //    return num1 / num2;
        //}
        //////////////////////////////////////////////////////////////////////////////////
        ///
        //static void Main(string[] args)
        //{
        //    int num1;
        //    int num2;

        //    Console.WriteLine("Input the first number: ");
        //    string input = Console.ReadLine();
        //    num1 = int.Parse(input);

        //    Console.WriteLine("Input the second number: ");
        //    input = Console.ReadLine();
        //    num2 = int.Parse(input);

        //    Console.WriteLine("The result is {0}", Calculate(num1, num2));
        //    Console.Read();

        //}

        //private static int Calculate(int num1, int num2)
        //{
        //    return num1 + num2;
        //}
        //////////////////////////////////////////////////////////////////////////////////

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Please enter a number: ");
        //    string userInput1 = Console.ReadLine();

        //    Console.WriteLine("Please enter another number: ");
        //    string userInput2 = Console.ReadLine();

        //    try
        //    {
        //        int result = int.Parse(userInput1) / int.Parse(userInput2);

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Format exception, please enter the correct type next time.");
        //    }
        //    catch (OverflowException)
        //    {
        //        Console.WriteLine("Overflow exception, please enter a smaller number next time (int32).");
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        Console.WriteLine("Argument null exception, the value was empty (null).");
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("Division by zero!");
        //    }
        //    finally
        //    {
        //        Console.WriteLine("This is called anyways.");
        //    }

        //    Console.Read();
        //}
        //////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            // post increment
            Console.WriteLine("num is {0}", num++);
            // pre increment
            Console.WriteLine("num is {0}", ++num);

            // decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            Console.WriteLine("num is {0}", --num);

            // additive operator
            int result;

            result = num1 + num2;
            Console.WriteLine("result or num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result or num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result or num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result or num1 * num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result or num1 % num2 is {0}", result);

            // relational and type operators

            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            // equality operator

            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            // conditional operators

            // and
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            // or
            bool isLowerOrSunny;
            isLowerOrSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerOrSunny);

            Console.Read();
        }
    }
}
