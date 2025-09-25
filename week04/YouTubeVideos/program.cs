using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("How to Cook Perfect Pasta", "Chef Mario", 420);
        video1.AddComment(new Comment("FoodLover123", "Great tips! My pasta turned out amazing."));
        video1.AddComment(new Comment("PastaPro", "I've been cooking pasta wrong my whole life!"));
        video1.AddComment(new Comment("MikeTheChef", "Simple yet effective techniques. Thanks!"));
        video1.AddComment(new Comment("CookingNewbie", "Finally a video that actually helps beginners!"));
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("10 Minute Morning Workout", "FitnessGuru", 600);
        video2.AddComment(new Comment("FitnessFan", "This workout is perfect for busy mornings!"));
        video2.AddComment(new Comment("HealthyLife", "Love how quick and effective this is."));
        video2.AddComment(new Comment("WorkoutWarrior", "Just what I needed to start my day right."));
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("Learn C# in 30 Minutes", "CodeMaster", 1800);
        video3.AddComment(new Comment("DevStudent", "Best C# tutorial I've found so far!"));
        video3.AddComment(new Comment("ProgrammerLife", "Clear explanations and great examples."));
        video3.AddComment(new Comment("CSharpLearner", "Helped me understand object-oriented concepts."));
        video3.AddComment(new Comment("CodeNewbie", "Finally, a tutorial that doesn't go too fast!"));
        videos.Add(video3);

        // Create fourth video
        Video video4 = new Video("Top 5 Travel Destinations 2024", "TravelExplorer", 480);
        video4.AddComment(new Comment("Wanderlust", "Adding all of these to my bucket list!"));
        video4.AddComment(new Comment("TravelBug", "Been to #3 and it's absolutely stunning!"));
        video4.AddComment(new Comment("AdventureSeeker", "Great video! When's the next one coming out?"));
        videos.Add(video4);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            
            Console.WriteLine(); // Empty line for spacing between videos
        }
    }
}