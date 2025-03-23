using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int increment)
    {
        playCount += increment;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Adrian Putra Perkasa]");
        video.IncreasePlayCount(5);
        video.PrintVideoDetails();
    }
}