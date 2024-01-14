using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int isContinue = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (isContinue != 0)
        {
            Console.Write("Enter number: ");
            int value = int.Parse(Console.ReadLine());
            numbers.Add(value);
            isContinue = value;
        }

        float sum = 0;
        float avg = 0;
        int largestNumber = 0;
        int? smallestNumber = null;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }

            if (smallestNumber == null || (number < smallestNumber && number > 0))
            {
                smallestNumber = number;
            }
        }

        avg = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"he average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");

        numbers.Sort();

        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}