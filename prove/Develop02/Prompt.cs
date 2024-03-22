using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
public class Prompt
{
    private List<string> prompts;
    private Random random;
   
    public Prompt()
    {
        prompts = new List<string>();
        InitializePrompts();
        random = new Random();
    }
    private void InitializePrompts()
    {
        prompts.Add("Top 3 things you have to do today?");
        prompts.Add("Did you make your bed today?");
        prompts.Add("How did your day go? ");
        prompts.Add("What did you do for yourself today? ");
        prompts.Add("Did you Yoga today? ");
    }
    public string GetRandomPrompt()
    {
        if (prompts.Count == 0)
        return "Ya got NO prompts!";
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    public void AddPrompt(string prompt)
    {
        prompts.Add(prompt);
    }
    public void RemovePrompt(string prompt)
    {
        prompts.Remove(prompt);
    }
}

   