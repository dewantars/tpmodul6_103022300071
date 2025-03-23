using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Judul tidak boleh kosong");

        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0)
            throw new ArgumentException("Play count tidak boleh negatif");

        this.playCount += count;
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
        video.IncreasePlayCount(100); 
        video.PrintVideoDetails();
    }
}
