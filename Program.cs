using System;

namespace AreEqualTwoDoubleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double diff = 0.000001;
            bool areEqual = false;

            if ( (Math.Abs(numberA) - Math.Abs(numberB)) < diff)
            {
                areEqual = true;
            }
            else
            {
                areEqual = false;
            }

            Console.WriteLine(areEqual);
            
        }
    }
}
