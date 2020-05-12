using ReportGeneration.Core.Domain;
using ReportGeneration.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ReportGeneration.Core.Services
{
    public class PostService : IPostService, IDisposable
    {
        private IPostUnitOfWork _postUnitOfWork;

        public PostService(IPostUnitOfWork postUnitOfWork)
        {
            _postUnitOfWork = postUnitOfWork;
        }

        public void CreatePost(Post post)
        {
            _postUnitOfWork.PostRepository.Add(post);
            _postUnitOfWork.Save();
        }

        public void Dispose()
        {
            _postUnitOfWork?.Dispose();
        }

        public (IList<Post> records, int total, int totalDisplay) 
            GetPosts(int pageIndex, int pageSize, string searchText, string sortText)
        {
            
            var result = _postUnitOfWork.PostRepository.Get(null, null,"Comments.Votes",pageIndex,pageSize,false);
            return (result.data, 0, 0);
        }
    }
}
