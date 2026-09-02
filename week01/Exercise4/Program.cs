using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.Write("Enter a list of numbers, type 0 when finished. ");
        int number;
        do
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
            // sum, average, and largest number calculation
        } while (number != 0);
        int sum = 0, max = numbers[0];
        foreach (int n in numbers)
        {
            sum += n;
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(double)sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {max}");
    }
}