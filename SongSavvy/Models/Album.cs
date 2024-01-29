using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SongSavvy.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The title can't be longer than 200 characters.")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<AlbumSong> AlbumSongs { get; set; }
    }
}
