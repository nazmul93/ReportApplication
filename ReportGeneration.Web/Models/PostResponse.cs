using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportGeneration.Web.Models
{
    public class PostResponse
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Creator { get; set; }
        public DateTime PostDate { get; set; }
        public int CommentCount { get; set; }
        public IList<CommentResponse> Comments { get; set; }
    }

    public class CommentResponse
    {
        public string Content { get; set; }
        public string Creator { get; set; }
        public DateTime PostDate { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
    }
}
