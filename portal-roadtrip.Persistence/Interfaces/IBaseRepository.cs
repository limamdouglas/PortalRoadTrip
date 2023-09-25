using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Persistence.Interfaces;

public interface IBaseRepository<T> where T : class
{
    Task<T> AddAsycn(T entity);
    T UpdateAsycn(T entity);
    bool Delete(T entity);
    bool DeleteRange(T entity);
    Task SaveChangesAsync();
    IQueryable<T> AsQueryable();
    IQueryable<T> AsQueryable(params Expression<Func<T, object>>[] includeProperties);
}
