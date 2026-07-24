using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learn C# in 20 Minutes", "Code Academy", 1200);
        video1.AddComment(new Comment("Stanley", "This tutorial was very helpful."));
        video1.AddComment(new Comment("Grace", "I finally understand classes."));
        video1.AddComment(new Comment("James", "Great explanation."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Travel Destinations", "Travel Guide", 850);
        video2.AddComment(new Comment("Sophia", "I want to visit Japan."));
        video2.AddComment(new Comment("Daniel", "Amazing video quality."));
        video2.AddComment(new Comment("Emma", "Thanks for sharing."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Healthy Breakfast Ideas", "Chef Mike", 600);
        video3.AddComment(new Comment("Olivia", "I'll try these recipes."));
        video3.AddComment(new Comment("Noah", "Looks delicious!"));
        video3.AddComment(new Comment("Lucas", "Simple and healthy."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Football Skills Compilation", "Sports Hub", 900);
        video4.AddComment(new Comment("Chris", "Those skills are incredible."));
        video4.AddComment(new Comment("Henry", "Best football video this year."));
        video4.AddComment(new Comment("Ella", "Very entertaining."));
        videos.Add(video4);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComment List:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}