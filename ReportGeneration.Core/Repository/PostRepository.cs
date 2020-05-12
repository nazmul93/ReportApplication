using ReportGeneration.Core.Data;
using ReportGeneration.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGeneration.Core.Repository
{
    public class PostRepository : Repository<Post, ReportDbContext>, IPostRepository
    {
        public PostRepository(ReportDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
