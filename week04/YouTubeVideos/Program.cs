using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("Intro to C#", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Great introduction, thanks!"));
        video1.AddComment(new Comment("Bob", "Very clear explanation."));
        video1.AddComment(new Comment("Charlie", "Helped me a lot, appreciate it!"));
        videos.Add(video1);

        
        Video video2 = new Video("Working with Classes in C#", "Dev World", 900);
        video2.AddComment(new Comment("Diane", "Now I understand classes better."));
        video2.AddComment(new Comment("Ethan", "Could you make one on interfaces?"));
        video2.AddComment(new Comment("Fiona", "Nice examples, well done."));
        videos.Add(video2);

        
        Video video3 = new Video("C# Lists and Loops", "Tech Tutorials", 750);
        video3.AddComment(new Comment("George", "Exactly what I needed today."));
        video3.AddComment(new Comment("Hannah", "The pace was perfect, thanks."));
        video3.AddComment(new Comment("Ian", "Subscribed to your channel!"));
        videos.Add(video3);

        Video video4 = new Video("Error Handling in C#", "Code Simplified", 830);
        video4.AddComment(new Comment("Jake", "Try catch finally makes sense now."));
        video4.AddComment(new Comment("Karen", "Can you cover custom exceptions?"));
        video4.AddComment(new Comment("Leo", "Very useful for my school project."));
        videos.Add(video4);

        
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(); 
        }

        
        Console.WriteLine("Press any key to exit...");
    }
}