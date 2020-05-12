using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ReportGeneration.Core.Repository
{
    public interface IRepository<TEntity, TContext>
        where TEntity : class
        where TContext : DbContext
    {
        void Add(TEntity entity);
        IList<TEntity> GetAll();
        (IList<TEntity> data, int total, int totalDisplay) Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);
    }
}
