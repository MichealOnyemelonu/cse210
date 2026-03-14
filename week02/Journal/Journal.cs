using System;


    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("The journal is empty.");
                return;
            }

            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Entry entry in _entries)
                    {
                        writer.WriteLine(entry.ToFileString());
                    }
                }

                Console.WriteLine("Journal saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving file: " + ex.Message);
            }
        }

        public void LoadFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            try
            {
                _entries.Clear();

                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    Entry entry = Entry.FromFileString(line);
                    if (entry != null)
                    {
                        _entries.Add(entry);
                    }
                }

                Console.WriteLine("Journal loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading file: " + ex.Message);
            }
        }
    }

