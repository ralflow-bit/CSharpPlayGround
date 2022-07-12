namespace CSharpPlayGround
{
    public class Song
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public int? Duration { get; set; }
        public static int Count = 0;
        public Song(string title, string artist, int duration)
        {
            Console.WriteLine("Now Playing");
            Title = title;
            Artist = artist;
            Duration = duration;
            Count++;
        }
    }
}