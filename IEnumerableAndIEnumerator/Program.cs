using System;

namespace IEnumerableAndIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach(Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
