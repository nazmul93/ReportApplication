using ReportGeneration.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportGeneration.Web.Models
{
    public class PostModel : PostBaseModel
    {
        public PostModel(IPostService postService) : base(postService) { }
        public PostModel() : base() { }

        internal object GetPosts(DataTableModel tableModel)
        {
            var presponse = new List<PostResponse>();
            var data = _postService.GetPosts(
                1,
                10,
                null,
                tableModel.GetSortText(new string[] { "Id", "Content", "User", "Date" }));

            foreach(var post in data.records)
            {
                var respone = new PostResponse
                {
                    Id = post.Id,
                    Content = post.Content,
                    Creator = post.UserId.ToString(),
                    PostDate = post.CreatedAt,
                    CommentCount = post.Comments.Count(),
                };
                var commentlist = new List<CommentResponse>();
                foreach(var comment in post.Comments)
                {
                    var c = new CommentResponse
                    {
                        Content = comment.Content,
                        Creator = comment.CommenterId.ToString(),
                        PostDate = comment.CreatedAt,
                        LikeCount = comment.Votes.Where(c=>c.IsLiked == true).Count(),
                        DislikeCount = comment.Votes.Where(c=> c.IsLiked == false).Count()
                    };
                    commentlist.Add(c);
                }
                respone.Comments = commentlist;
                presponse.Add(respone);
            }
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = presponse
            };
        }
    }
}
