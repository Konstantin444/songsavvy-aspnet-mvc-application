using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SongSavvy.Models
{
    public class Song
    {
        public int SongID { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The title can't be longer than 200 characters.")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The genre can't be longer than 50 characters.")]
        public string Genre { get; set; }

        [Required]
        [Range(1900, 2024, ErrorMessage = "The release year must be between 1900 and 2024.")]
        public int ReleaseYear { get; set; }

        [Required]
        public int ArtistID { get; set; }
        public virtual Artist Artist { get; set; }

        public virtual ICollection<AlbumSong> AlbumSongs { get; set; }
    }
}
