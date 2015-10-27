namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ChatMessage
    {
        private ICollection<Friendship> friendships;
        private ICollection<ChatMessage> chatMessages;

        public ChatMessage()
        {
            this.chatMessages = new HashSet<ChatMessage>();
            this.friendships = new HashSet<Friendship>();
        }

        [Key]
        public int Id { get; set; }

        public string Author { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime SendDateTime { get; set; }

        public DateTime SeenDateTime { get; set; }

        public virtual ICollection<Friendship> Friendships
        {
            get { return this.friendships; }
            set { this.friendships = value; }
        }
    }
}