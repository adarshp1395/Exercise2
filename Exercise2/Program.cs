using System;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            int heartrate;
            // Max heart rate = 220 - age

            age = 24;
            height = 161;
            heartrate = 220 - age;
            Console.WriteLine("I am " + age + "years old. Max heartrate is " + heartrate);
        }
    }
}
