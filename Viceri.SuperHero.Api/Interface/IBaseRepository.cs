using System.Linq.Expressions;
using Viceri.SuperHero.Api.Entity;

namespace Viceri.SuperHero.Api.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task SaveChanges();
        Task<bool> Exist(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll();
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}
