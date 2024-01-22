using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int randomIndex = random.Next(_prompts.Count);

        return _prompts[randomIndex];
    }
}