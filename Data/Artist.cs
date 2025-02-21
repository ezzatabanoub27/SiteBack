using System.ComponentModel.DataAnnotations;

namespace Ray2.Data
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        [Required]
        [MaxLength(50)]
        public string  Name { get; set; }
        public string? PictureUrl { get; set; }

        public string? Bio { get; set; }

        public ICollection<Track> tracks { get; set; }
        public ICollection<Album> albums { get; set; }
    }
}
