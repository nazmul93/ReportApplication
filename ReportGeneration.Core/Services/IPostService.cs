using ReportGeneration.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGeneration.Core.Services
{
    public interface IPostService : IDisposable
    {
        (IList<Post> records, int total, int totalDisplay) GetPosts(int pageIndex,
                                                                    int pageSize,
                                                                    string searchText,
                                                                    string sortText);
        void CreatePost(Post post); 
    }
}
