using ReportGeneration.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGeneration.Core.Repository
{
    public class PostUnitOfWork : UnitOfWork, IPostUnitOfWork
    {
        public IPostRepository PostRepository { get; set; }
        public PostUnitOfWork(ReportDbContext context, IPostRepository postRepository)
            : base(context)
        {
            PostRepository = postRepository;
        }
    }
}
