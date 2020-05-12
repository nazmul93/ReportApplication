using ReportGeneration.Core.Data;
using ReportGeneration.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGeneration.Core.Repository
{
    public interface IPostRepository : IRepository<Post, ReportDbContext>
    {
    }
}
