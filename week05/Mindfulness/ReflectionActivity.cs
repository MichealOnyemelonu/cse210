using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can this experience help you in the future?"
    };

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience."
          )
    { }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter.");
        Console.ReadLine();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            ShowSpinner(5);
            Console.WriteLine();

            elapsed += 5;
        }

        EndActivity();
    }
}