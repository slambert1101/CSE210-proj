using System;

class Program
{
    static void Main(string[] args)
    {
        CommentGenerator generator = new CommentGenerator();
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Car repair", "Crazy George", 45);
        video1.AddComment(generator.GenerateComment());
        video1.AddComment(generator.GenerateComment());
        video1.AddComment(generator.GenerateComment());
        videos.Add(video1);

        Video video2 = new Video("BIG fails", "Charlie the beast", 92);
        video2.AddComment(generator.GenerateComment());
        video2.AddComment(generator.GenerateComment());
        video2.AddComment(generator.GenerateComment());
        video2.AddComment(generator.GenerateComment());
        videos.Add(video2);

        Video video3 = new Video("Install a light fixture with ease!", "Mike the electrician", 31);
        video3.AddComment(generator.GenerateComment());
        video3.AddComment(generator.GenerateComment());
        video3.AddComment(generator.GenerateComment());
        videos.Add(video3);

        Console.Clear();
        foreach(Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
        
    }
}