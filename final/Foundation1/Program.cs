using System;

class Program
{
    static void Main(string[] args)
    {
        // A list of videos
        List<Video> videosList = new List<Video>();

        // A new video 
        Video myVideo1 = new Video("Travel Vlog", "HikerMan32", 1200);
        Comment myComment1 = new Comment("Trolly", "I like this video!");
        Comment myComment2 = new Comment("Brock", "Not my favorite video but I like it.");
        Comment myComment3 = new Comment("Misty", "I want to be you!");
        myVideo1.AddComment(myComment1);
        myVideo1.AddComment(myComment2);
        myVideo1.AddComment(myComment3);

        // Adds the video object to the list
        videosList.Add(myVideo1);

        Video myVideo2 = new Video("Trolly eats ice cream", "Troly", 3200);
        Comment myComment4 = new Comment("HikerMan32", "Can you eat anything else??");
        Comment myComment5 = new Comment("Brock", "Now this is amazing");
        Comment myComment6 = new Comment("Misty", "I feel sick....");
        myVideo2.AddComment(myComment4);
        myVideo2.AddComment(myComment5);
        myVideo2.AddComment(myComment6);

        // Adds the video object to the list
        videosList.Add(myVideo2);

        Video myVideo3 = new Video("Dinesy Land", "Misty", 600);
        Comment myComment8 = new Comment("Brock", "I've seen better");
        Comment myComment9 = new Comment("Sarah", "Love the trip");
        myVideo3.AddComment(myComment8);
        myVideo3.AddComment(myComment9);

        // Adds the video object to the list
        videosList.Add(myVideo3);

        // display video info and comments
        foreach (Video video in videosList)
        {
            video.Display();
        }
        
    }
}