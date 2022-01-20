using System;

namespace ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i= 0; i<10; i++)
            {
                nums[i] = i + 10;
            }

            for(int j = 0; j<nums.Length; j++)
            {
                Console.WriteLine("Element at {0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element at {0} = {1}", counter++, k);
            }

            string[] friends = { "Miguel", "Jerson", "Eric", "Nicolas", "Carlos"};

            foreach(string friend in friends)
            {
                Console.WriteLine("Good morning, {0}!", friend);
            }

            Console.Read();
        }
    }
}
