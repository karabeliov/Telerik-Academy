namespace SocialNetwork.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        private ICollection<Post> tagInPosts;

        public Image()
        {
            this.tagInPosts = new HashSet<Post>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Url { get; set; }

        [MaxLength(4)]
        public string FileExtension { get; set; }

        public virtual ICollection<Post> TagInPosts
        {
            get { return this.tagInPosts; }
            set { this.tagInPosts = value; }
        }
    }
}