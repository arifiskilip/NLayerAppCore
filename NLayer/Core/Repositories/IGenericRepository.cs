using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IGenericRepository<T> where T: class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        // .Where(..).OrderBy().ToList()
        IQueryable<T> Where(Expression<Func<T, bool>> filter);
        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        Task AddRangeAsync(IQueryable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IQueryable<T> entities);
    }
}
