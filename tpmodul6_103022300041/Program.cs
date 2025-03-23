using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100, "Judul video tidak boleh null atau lebih dari 100 karakter.");

        Random random = new Random();
        this.id = random.Next(10000, 100000); // 5 digit random number
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int increment)
    {
        Debug.Assert(increment > 0 && increment <= 10000000, "Increment play count harus antara 1 hingga 10.000.000.");

        try
        {
            checked
            {
                this.playCount += increment;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow terjadi! Play count mencapai batas maksimum integer.");
        }
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
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Adrian Putra Perkasa]");
            for (int i = 0; i < 100000; i++) // Loop besar untuk mempercepat overflow
            {
                video.IncreasePlayCount(1000000); // Tes overflow
            }
            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi error: " + ex.Message);
        }

        Console.WriteLine("Program selesai.");
        Console.ReadLine();
    }
}