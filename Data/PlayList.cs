using System.ComponentModel.DataAnnotations;

namespace Ray2.Data
{
    public class PlayList
    {
        [Key]
        public int PlayListId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int userid { get; set; }
        public User user { get; set; }
        public ICollection<PlayListT_Track>playtrack { get; set; }

    }
}
