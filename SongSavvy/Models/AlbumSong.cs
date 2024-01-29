namespace SongSavvy.Models
{
    public class AlbumSong
    {
        public int Id { get; set; }

        public int AlbumID { get; set; }
        public virtual Album Album { get; set; }

        public int SongID { get; set; }
        public virtual Song Song { get; set; }
    }

}
