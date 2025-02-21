using System.ComponentModel.DataAnnotations;

namespace Ray2.Data
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public TimeSpan Duration { get;set; }
        public string Track_URL { get; set; }
        public bool Trendy { get; set;}
        public bool? Romantic { get; set;}
        public bool? Rab { get; set; }
        public bool? Happy { get; set; }
        public bool? Sad { get; set; }
        public bool? Relaxing { get; set; }
        public bool? Mahraganat { get; set; }
        //album
        public int? albumId { get; set; }    

        public Album? album { get; set; }
        //artist
        public int? artistiD { get; set; }
        public Artist? artist { get; set; }

        public ICollection<PlayListT_Track> playtracks { get; set; }
    }
}
