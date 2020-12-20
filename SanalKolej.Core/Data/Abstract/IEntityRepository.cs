using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SanalKolej.Core.Entities.Abstract;

namespace SanalKolej.Core.Data.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {

        Task<T> GetAsync(Expression<Func<T,bool>> predicate, 
        params Expression<Func<T,object>>[] includeProperties);
        Task<IList<T>> GetAllAsync(Expression<Func<T,bool>> predicate, params Expression<Func<T,object>>[] includeProperties);

        Task<T> GetByIdAsync(int Id); 

        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T,bool>> predicate);
           
        Task<int> Count(Expression<Func<T,bool>> predicate);
    }
}