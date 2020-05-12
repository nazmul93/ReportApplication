using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ReportGeneration.Core.Domain
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
