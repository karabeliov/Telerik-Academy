namespace SocialNetwork.Data
{
    using System.Data.Entity;
    using SocialNetwork.Models;

    public class SocialNetworkDbContext : DbContext
    {
        public SocialNetworkDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Image> Images { get; set; }

    }
}
