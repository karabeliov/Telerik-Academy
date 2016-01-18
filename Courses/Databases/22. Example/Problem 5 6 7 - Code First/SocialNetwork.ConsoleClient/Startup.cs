
namespace SocialNetwork.ConsoleClient
{
    using SocialNetwork.Data;
    using SocialNetwork.Models;

    public class Startup
    {
        public static void Main()
        {
            var db = new SocialNetworkDbContext();
            var user = new UserProfile
            {
                UserName = "picha",
                FirstName = "Pesho",
                LastName = "Peshev"
            };

            db.UserProfiles.Add(user);

            var post = new Post();
            db.SaveChanges();
        }
    }
}
