using System;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            Console.WriteLine($"{a}/{b} is " + a/b + " remainder " + a%b);

            Console.WriteLine("What is the radius of your circle");

            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");

        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
