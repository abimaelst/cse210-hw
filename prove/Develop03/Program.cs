using System;

class Program
{
    static void Main(string[] args)
    {

        Random rnd = new Random();

        int verseStart = rnd.Next(1, 36);

        int verseEnd = 0;

        Reference reference;

        if (verseStart < 36)
        {
            verseEnd = verseStart + 1;
            reference = new Reference("John", 3, verseStart, verseEnd);
        }
        else
        {
            reference = new Reference("John", 3, verseStart);
        }


        FileReader file = new FileReader("scripture.txt");

        List<string> lines = file.GetLines();

        string text = lines[verseStart + 1].Split("|")[1];

        if (verseEnd != 0)
        {
            text += $" {lines[verseEnd + 1].Split("|")[1]}";
        }

        Scripture scripture = new Scripture(reference, text);

        bool isFinished = false;

        while (!isFinished)
        {
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress enter to continue or 'quit' to finish:");
            string response = Console.ReadLine();

            if (response == "quit" || scripture.AllWordsHidden())
            {
                isFinished = true;
                return;
            }


            scripture.HideRandomWords(2);

            Console.Clear();


        }


    }
}