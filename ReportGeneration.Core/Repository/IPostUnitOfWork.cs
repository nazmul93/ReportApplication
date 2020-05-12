using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGeneration.Core.Repository
{
    public interface IPostUnitOfWork : IUnitOfWork
    {
        IPostRepository  PostRepository { get; set; }
    }
}
