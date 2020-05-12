using ReportGeneration.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReportGeneration.Web.Models
{
    public class PostComment
    {
        [Required]
        public string Content { get; set; }
        public int CommenterId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PostId { get; set; }

        public Comment CreateComment()
        {
            var comment = new Comment
            {
                Content = Content,
                CommenterId = CommenterId,
                CreatedAt = DateTime.Now,
                PostId = PostId
            };
            return comment;
        }
    }
}
