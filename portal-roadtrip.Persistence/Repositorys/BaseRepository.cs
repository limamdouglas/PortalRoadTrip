using Microsoft.EntityFrameworkCore;
using portal_roadtrip.Persistence.Context;
using portal_roadtrip.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Persistence.Repositorys;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly DataContext Context;

    private DbSet<T> DbSetRoadTrip;
    public BaseRepository(DataContext context)
    {
        Context = context;
        DbSetRoadTrip = Context.Set<T>();
    }

    public async Task<T> AddAsycn(T entity)
    {
        await DbSetRoadTrip.AddAsync(entity);
        return entity;
    }

    public virtual T UpdateAsycn(T entity)
    {
        Context.Entry(entity).CurrentValues.SetValues(entity);

        return entity;
    }

    public bool Delete(T entity)
    {
        DbSetRoadTrip.Remove(entity);
        return true;
    }

    public bool DeleteRange(T entity)
    {
        DbSetRoadTrip.RemoveRange(entity);
        return true;
    }

    public virtual async Task SaveChangesAsync()
    {
        await Context.SaveChangesAsync();
    }

    public IQueryable<T> AsQueryable()
    {
        return DbSetRoadTrip.AsQueryable();
    }

    public IQueryable<T> AsQueryable(params Expression<Func<T, object>>[] includeProperties)
    {
        IQueryable<T> query = Context.Set<T>();
        return includeProperties.Aggregate(query, (current, includeProperties) => current.Include(includeProperties));
    }
}