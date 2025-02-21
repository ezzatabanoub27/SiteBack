using System.ComponentModel.DataAnnotations;

namespace Ray2.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string? pictureUrl { get; set; }

        public ICollection<Favorite> Favorite { get; set; }
        public ICollection<PlayList> PlayList { get; set; }

    }
}
