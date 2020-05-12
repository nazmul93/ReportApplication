using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ReportGeneration.Core.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [ForeignKey("Recipient")]
        public int CommenterId { get; set; }
        public User Commenter { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Vote> Votes { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
