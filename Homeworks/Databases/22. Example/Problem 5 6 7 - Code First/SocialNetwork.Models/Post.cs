namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public  class Post
    {
        private ICollection<UserProfile> userProfile;

        public Post()
        {
            this.userProfile = new HashSet<UserProfile>();
        }

        [Key]
        public int Id { get; set; }

        [MinLength(10)]
        [Required]
        public string Content { get; set; }

        public DateTime PostDate { get; set; }

        public virtual ICollection<UserProfile> UserProfile
        {
            get { return this.userProfile; }
            set { this.userProfile = value; }
        }
    }
}