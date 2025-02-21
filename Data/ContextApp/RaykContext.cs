using Microsoft.EntityFrameworkCore;

namespace Ray2.Data.ContextApp
{
    public class RaykContext:DbContext
    {
        public RaykContext(DbContextOptions<RaykContext> options) : base(options)
        { 

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<PlayListT_Track> playListT_Tracks { get; set; }


    }
}
