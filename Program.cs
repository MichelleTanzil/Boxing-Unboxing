using System;
using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> newObject = new List<object>();
            newObject.Add(7);
            newObject.Add(28);
            newObject.Add(-1);
            newObject.Add(true);
            newObject.Add("chair");

            int sum = 0;
            for (int i = 0; i < newObject.Count; i++)
            {
                if (newObject[i] is int) 
                {
                    Console.WriteLine($"This is an integer: {newObject[i]}");
                    int ActualInt = (int)newObject[i];
                    sum += ActualInt;
                }
                else if (newObject[i] is string) 
                {
                    Console.WriteLine($"This is an string: {newObject[i]}");
                }
                else if (newObject[i] is bool)
                {
                    Console.WriteLine($"This is an boolean: {newObject[i]}");
                }
            }
            Console.WriteLine($"The sum of the integers is {sum}.");
        }
    }
}
