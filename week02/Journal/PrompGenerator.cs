using System;

    public class PromptGenerator
    {
        private List<string> _prompts;
        private Random _random = new Random();

        public PromptGenerator()
        {
            _prompts = new List<string>
            {
                "Who was the most interesting person you interacted with today?",
                "What was the best part of your day?",
                "What was the strongest emotion you felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What is one thing I learned today?",
                "Are you enjoying the class?",
                "What am I grateful for today?"
            };
        }

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }
    }

