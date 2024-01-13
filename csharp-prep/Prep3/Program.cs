using System;

class Program
{
    static void Main(string[] args)
    {
        string isContinue;

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

            int luckNumber = randomGenerator.Next(1, 100);
            Console.Write($"What is the magic number? {luckNumber}");

            Console.WriteLine();

            Console.Write("What is your guess? ");
            int guessNumber = int.Parse(Console.ReadLine());


            while (guessNumber != number)
            {
                if (number > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }

                Console.WriteLine("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You guessed it!");

            Console.WriteLine("You want to play again? yes or no");
            isContinue = Console.ReadLine();

            while (isContinue != "yes" || isContinue != "no") {
                Console.WriteLine("Please enter a valid answer. yes or no");
                isContinue = Console.ReadLine();
            }

        } while (isContinue == "yes");
    }
}