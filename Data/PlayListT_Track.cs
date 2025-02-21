using System.ComponentModel.DataAnnotations;

namespace Ray2.Data
{
    public class PlayListT_Track
    {
        [Key]
        public int Id { get; set; } 
        public int playlistId { get; set; }
        public PlayList playlist { get; set; }
        public int trackId { get; set; }
        public Track track { get; set; }


    }
}
