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
            var data = _postService.GetPosts(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Id", "Content", "User", "Date" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                            record.Id.ToString(),
                            record.Content,
                            record.UserId.ToString(),
                            record.CreatedAt.ToString(),
                        }
                    ).ToArray()

            };
        }
    }
}
