using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Cooking Utensils", "Olaoluwa Damilola", 100);
        video1.AddComment("Mike", "Great tutorial!");
        video1.AddComment("Ifeoluwa", "The video was very informative.");
        video1.AddComment("Mary", "Could you make a tutorial on how to use them?");
        videos.Add(video1);

        Video video2 = new Video("Baking Equipments", "Charles Okonkwo", 3000);
        video2.AddComment("Ireti", "Awesome analysis of the equipments!");
        video2.AddComment("Francis", "What are the best ways to preseve the equipments after use?");
        video2.AddComment("Yvonne", "Learning how to use the equipment was very helpful.");
        videos.Add(video2);

        Video video3 = new Video("Latest baking products from ABC", "Adeoluwa Johnson", 1800);
        video3.AddComment("Harry", "Thank you for the video!");
        video3.AddComment("Durotoluwa", "Well explained video. I have really learned a lot from it.");
        video3.AddComment("Marcus", "After your video, I can proudly call myself a baker haha!");
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.videoDescription();
        }
    }
}


class Comment
{
    public string _commentator { get; set; }
    public string _Text { get; set; }

    public Comment(string newComment, string message)
    {
        _commentator = newComment;
        _Text = message;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(string newComment, string message)
    {
        Comment comment = new Comment(newComment, message);
        Comments.Add(comment);
    }

    public int totalComments()
    {
        return Comments.Count;
    }

    public void videoDescription()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length (seconds): {LengthSeconds}");
        Console.WriteLine("Number of comments: " + totalComments());
        Console.WriteLine("\nComments");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"{comment._commentator}: {comment._Text}");
        }
        Console.WriteLine();
    }
}