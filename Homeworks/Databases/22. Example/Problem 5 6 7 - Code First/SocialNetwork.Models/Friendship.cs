namespace SocialNetwork.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Friendship
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstUser { get; set; }

        [Required]
        public string SecondUser { get; set; }

        public bool HasFriendship { get; set; }

        public DateTime ApprovedDate { get; set; }
    }
}