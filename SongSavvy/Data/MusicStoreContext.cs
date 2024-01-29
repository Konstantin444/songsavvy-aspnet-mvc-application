using Microsoft.EntityFrameworkCore;
using SongSavvy.Models;

namespace SongSavvy.Data
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext(DbContextOptions<MusicStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumSong> AlbumSongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AlbumSong>()
                .HasKey(as => new { as.AlbumID, as.SongID }); // Composite key

            modelBuilder.Entity<AlbumSong>()
                .HasOne(as => as.Album)
                .WithMany(a => a.AlbumSongs)
                .HasForeignKey(as => as.AlbumID);

            modelBuilder.Entity<AlbumSong>()
                .HasOne(as => as.Song)
                .WithMany(s => s.AlbumSongs)
                .HasForeignKey(as => as.SongID);
        }
    }
}
