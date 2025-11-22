using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video ("How to install a door","Jeff Teaches", 15);
        video1.AddComment(new Comment("Claire","Love the video, thank you for sharing your knowledge."));
        video1.AddComment(new Comment("Elsa","This explanation was very useful."));
        video1.AddComment(new Comment("Jamie","This explanation was great."));
        Video video2 = new Video("Fixing the disposal", "Jeff Teaches", 10);
        video2.AddComment(new Comment("Fiona","Thank you for sharing your knowledge."));
        video2.AddComment(new Comment("Grace","Thanks!."));
        video2.AddComment(new Comment("John","Thanks, very useful!"));
        Video video3 = new Video("Unclogging the sink","John Teaching",8);
        video3.AddComment(new Comment("Marcy","This save me calling hte plumber."));
        video3.AddComment(new Comment("Paul","Thank you for this video."));
        video3.AddComment(new Comment("John","Thank you."));
        Video video4 = new Video("How to fix the shed","John Teaching",15);
        video4.AddComment(new Comment("James","Thanks!."));
        video4.AddComment(new Comment("Rosa","Thank you!."));
        video4.AddComment(new Comment("Sam","Thank you, good content.!"));
        Console.WriteLine(video1.DisplayText());
        Console.WriteLine(video2.DisplayText());
        Console.WriteLine(video3.DisplayText());
        Console.WriteLine(video4.DisplayText());

       

    }
}