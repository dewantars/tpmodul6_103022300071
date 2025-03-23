using System;
using System.Diagnostics;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(!string.IsNullOrEmpty(title), "Title tidak boleh kosong");
        Debug.Assert(title.Length <= 100, "panjang title tidak boleh lebih dari 100");

        Random random = new Random();
        this.id = random.Next(10000, 99999); 
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count > 0 && count <= 10000000, "Play count tidak valid");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: Play count overflow. " + ex.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video Details:");
        Console.WriteLine($"ID: {this.id}");
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"Play Count: {this.playCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [DEWANTA RS]");

        for (int i = 0; i < 25; i++) // pengujian overflow
        {
            video.IncreasePlayCount(100000000);
        }

        video.PrintVideoDetails();
    }
}
