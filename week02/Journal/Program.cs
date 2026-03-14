// In this task i added Extra features to show my creativity:
// I added basic error handling when saving and loading files.
// Also added "MOOD RATING" (1–5) TO EACH ENTRY AND DISPLAYED IT WITH JOURNAL ENTRIES.


using System;



    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("Journal Menu");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");
                Console.Write("Choose an option (1-5): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        WriteNewEntry(journal, promptGenerator);
                        break;

                    case "2":
                        journal.DisplayAll();
                        break;

                    case "3":
                        SaveJournal(journal);
                        break;

                    case "4":
                        LoadJournal(journal);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1 - 5.");
                        break;
                }
            }
        }

        private static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
        {
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine("Prompt:");
            Console.WriteLine(prompt);
            Console.WriteLine();
            Console.Write("Your response: ");
            string response = Console.ReadLine();

            int mood = ReadMoodFromUser();

            string dateText = DateTime.Now.ToString("yyyy-MM-dd");

            Entry entry = new Entry(dateText, prompt, response, mood);
            journal.AddEntry(entry);

            Console.WriteLine("Entry added.");
        }


        private static int ReadMoodFromUser()
        {
            while (true)
            {
                Console.Write("How is your mood today (1-5, where 1 = very bad, 2 = normal, 3 = Okay, 4 = Very good, 5 = excellent):");

                string input = Console.ReadLine();
                
                if (int.TryParse(input, out int mood))
                
                {
                    if (mood >= 1 && mood <= 5)
                    {
                        return mood;
                    }
                }
                
                Console.WriteLine("Please enter a number between 1 and 5.");

            }
        }

        private static void SaveJournal(Journal journal)
        {
            Console.Write("Enter filename to save (e.g., journal.txt): ");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
        }

        private static void LoadJournal(Journal journal)
        {
            Console.Write("Enter filename to load (e.g., journal.txt): ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
        }
    }
