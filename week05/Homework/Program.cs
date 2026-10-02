using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 1
            Assignment a1 = new Assignment("Junior Mapisa", "Multiplication");
            Console.WriteLine(a1.GetSummary());
            Console.WriteLine();

            // Test 2 - Math
            MathAssignment m1 = new MathAssignment("loveness Dube", "Fractions", "7.3", "8-19");
            Console.WriteLine(m1.GetSummary());
            Console.WriteLine(m1.GetHomeworkList());
            Console.WriteLine();

            // Test 3 - Writing
            WritingAssignment w1 = new WritingAssignment("Eruption Volcano", "European History", "The Causes of hot melted rocks");
            Console.WriteLine(w1.GetSummary());
            Console.WriteLine(w1.GetWritingInformation());
        }
    }
}