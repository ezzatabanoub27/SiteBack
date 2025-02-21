using System.ComponentModel.DataAnnotations;

namespace Ray2.Data
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public string? Cover_URL { get; set; }
        public ICollection<Track> track { get; set; }
        public int artistId { get; set; }

        public Artist artist { get; set; }

    }
}
