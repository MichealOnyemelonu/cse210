using System;


    public class Entry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }
        public int Mood { get; set; }  

        public Entry(string date, string prompt, string response, int mood)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
            Mood = mood;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Mood (1-5): {Mood}");
            Console.WriteLine($"Prompt: {Prompt}");
            Console.WriteLine($"Response: {Response}");
            Console.WriteLine("------------------------------");
        }

    
        public string ToFileString()
        {
            return $"{Date}|{Mood}|{Prompt}|{Response}";
        }


        public static Entry FromFileString(string line)
        {
            string[] parts = line.Split('|');

            if (parts.Length < 4)
            {
                return null;
            }

            string date = parts[0];

            int mood = 3; 
            int.TryParse(parts[1], out mood);

            string prompt = parts[2];
            string response = parts[3];

            return new Entry(date, prompt, response, mood);
        }
    }
