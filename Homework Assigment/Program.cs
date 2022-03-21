using System;

namespace Homework_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hours: ");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter minutes: ");
            int minute = Convert.ToInt32(Console.ReadLine());

            Clock clock = new Clock(hour, minute);

            Console.WriteLine("Lesser angle in degrees between hour and minutes is: {0}", clock.CalculateAngle());
        }
    }
}
