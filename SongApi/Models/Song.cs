namespace SongApi.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string artist { get; set; }
        public string? album { get; set; }
        public string title { get; set; }
        public int length { get; set; }
        public string category { get; set; }

    }
}
