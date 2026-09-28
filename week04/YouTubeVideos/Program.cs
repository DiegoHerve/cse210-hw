using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "John Smith", 600);
        video1.addComment(new Comment("Alice", "Great video!"));
        video1.addComment(new Comment("Mark", "I learned a lot."));
        video1.addComment(new Comment("Sarah", "Very helpful explanation."));

    
        Video video2 = new Video("Introduction to Programming", "David Jones", 450);
        video2.addComment(new Comment("Mike", "Nice explanation."));
        video2.addComment(new Comment("Anna", "This was useful."));
        video2.addComment(new Comment("Peter", "I understand it better now."));
        video2.addComment(new Comment("Lisa", "Thank you for the lesson."));

    
        Video video3 = new Video("Object Oriented Programming", "Emily Brown", 720);
        video3.addComment(new Comment("James", "I really enjoyed this."));
        video3.addComment(new Comment("Sophie", "Good examples."));
        video3.addComment(new Comment("Daniel", "Very clear and simple."));

        Video video4 = new Video("C# Classes and Objects", "Michael Wilson", 510);
        video4.addComment(new Comment("Chris", "This helped me understand classes."));
        video4.addComment(new Comment("Emma", "Excellent tutorial."));
        video4.addComment(new Comment("Ryan", "Looking forward to the next video."));
        video4.addComment(new Comment("Olivia", "Great work!"));

        
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

    
        foreach (Video video in videos)
        {
            video.displayVideo();
            Console.WriteLine();
        }
    }
}




















