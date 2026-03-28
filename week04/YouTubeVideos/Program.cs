using System;
using System.Security.Authentication;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        //Video 1
        Video video1 = new Video();
        video1.SetTitle("Video 1");
        video1.SetAuthor("Juan Pablo");
        video1.SetLength(90);

        Comment c10 = new Comment();
        c10.setName("Jhon");
        c10.setText("Excelent work");
        video1.AddComment(c10);

        Comment c20 = new Comment();
        c20.setName("Joseph");
        c20.setText("Great Video");
        video1.AddComment(c20);


        //Video 2
        Video video2 = new Video();
        video2.SetTitle("Video 2");
        video2.SetAuthor("Juan Pablo");
        video2.SetLength(120);

        Comment c11 = new Comment();
        c11.setName("Mia");
        c11.setText("Excelent work");
        video2.AddComment(c11);

        Comment c21 = new Comment();
        c21.setName("Mathew");
        c21.setText("Great Video");
        video2.AddComment(c21);

        //Video 3
        Video video3 = new Video();
        video3.SetTitle("Video 3");
        video3.SetAuthor("Juan Pablo");
        video3.SetLength(60);

        Comment c12 = new Comment();
        c12.setName("Mary");
        c12.setText("Excelent");
        video3.AddComment(c12);

        Comment c22 = new Comment();
        c22.setName("Paul");
        c22.setText("Great Video");
        video3.AddComment(c22);


        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach(Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}