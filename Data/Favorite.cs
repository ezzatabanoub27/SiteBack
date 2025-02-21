using System.ComponentModel.DataAnnotations;

namespace Ray2.Data
{
    public class Favorite
    {
        [Key]
        public int FavoriteId { get; set; }

        public DateTime? AddedAt { get; set; }
        public int userid { get; set; }

        public User user { get; set; }

    }
}
