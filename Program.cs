using System;

namespace Lab_01___zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(1, 3);

            Console.WriteLine(fraction1.CompareTo(fraction2));

        }
    }
}
