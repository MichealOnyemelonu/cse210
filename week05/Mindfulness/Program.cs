// EXCEEDING REQUIREMENTS: 
// This program tracks how many mindfulness activities the user completes 
// during a session and displays the total when the user quits the program. 
// This provides additional feedback and encouragement beyond the core requirements.


using System;
using System.Threading;

class Program
{
    static void Main()
    {

        int completedActivities = 0;
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    completedActivities++;
                    break;

                case "2":
                    new ReflectionActivity().Run();
                    completedActivities++;
                    break;

                case "3":
                    new ListingActivity().Run();
                    completedActivities++;
                    break;

                case "4":
                    Console.WriteLine();
                    Console.WriteLine($"You completed {completedActivities} mindfulness activities this session. Great job!");
                    Thread.Sleep(3000);
                    break;
            }
        }
    }
}