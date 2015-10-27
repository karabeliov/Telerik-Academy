namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class UserProfile
    {
        private ICollection<Image> images;
        private ICollection<Post> posts;
        private ICollection<Friendship> friendships;
        private ICollection<ChatMessage> chatMessages;

        public UserProfile()
        {
            this.images = new HashSet<Image>();
            this.posts = new HashSet<Post>();
            this.friendships = new HashSet<Friendship>();
            this.chatMessages = new HashSet<ChatMessage>();
        }

        [Key]
        public int Id { get; set; }

        [MinLength(4)]
        [MaxLength(20)]
        [Required]
        public string UserName { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<Image> Images
        {
            get { return this.images; }
            set { this.images = value; }
        }

        public virtual ICollection<Post> Posts
        {
            get { return this.posts; }
            set { this.posts = value; }
        }

        public virtual ICollection<Friendship> Friendships
        {
            get { return this.friendships; }
            set { this.friendships = value; }
        }

        public virtual ICollection<ChatMessage> Messages
        {
            get { return this.chatMessages; }
            set { this.chatMessages = value; }
        }
    }
}
