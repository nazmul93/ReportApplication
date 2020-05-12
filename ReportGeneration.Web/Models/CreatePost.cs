using ReportGeneration.Core.Domain;
using ReportGeneration.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReportGeneration.Web.Models
{
    public class CreatePost : PostBaseModel
    {
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Content { get; set; }
        [Required]
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }

        public CreatePost(IPostService postService) : base(postService) { }

        public CreatePost() : base()
        {

        }

        public void Create()
        {
            var post = new Post
            {
                Content = Content,
                CreatedAt = DateTime.Now,
                UserId = UserId
            };
            _postService.CreatePost(post);
        }

    }
}
