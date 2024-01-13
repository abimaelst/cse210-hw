using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the score: ");
        int grade = int.Parse(Console.ReadLine());

        string letter;
        string symbol = "";
        int rest;


        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "E";
        }

        rest = grade % 10;

        if (rest >= 7 && grade < 90)
        {
            symbol = "+";
        }
        else if (rest <= 3)
        {
            symbol = "-";
        }

        Console.WriteLine($"The final score is {letter}{symbol}");


    }
}