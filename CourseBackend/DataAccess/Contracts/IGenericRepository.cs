using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts;
public interface IGenericRepository<T,TKey>
    where T : BaseEntity<TKey>,new()

{
    IQueryable<T> FindAll(bool changeTracker);
    IQueryable<T> FindCondition(Expression<Func<T, bool>> predicate,bool changeTracker);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}