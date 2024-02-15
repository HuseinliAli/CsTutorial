using DataAccess.Concretes.Contexts;
using DataAccess.Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.Repos;
public class GenericRepository<T, TKey>(ApplicationContext context) : IGenericRepository<T, TKey>
    where T : BaseEntity<TKey>, new()
{
    protected DbSet<T> table = context.Set<T>();

    public void Create(T entity)
        => table.Add(entity);

    public void Delete(T entity)
        => table.Remove(entity);

    public IQueryable<T> FindAll(bool changeTracker)
        => !changeTracker ? table.AsNoTracking() : table;

    public IQueryable<T> FindCondition(Expression<Func<T, bool>> predicate, bool changeTracker)
        => !changeTracker ? table.Where(predicate).AsNoTracking() :
            table.Where(predicate);

    public void Update(T entity)
        => table.Update(entity);
}