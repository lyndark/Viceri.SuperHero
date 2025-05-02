using System.Linq.Expressions;
using Viceri.SuperHero.Api.Entity;
using Microsoft.EntityFrameworkCore;
using Viceri.SuperHero.Api.Interface;
using Viceri.SuperHero.Api.Infrastructure;

namespace Viceri.SuperHero.Api.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected AppDbContext Context { get; set; }  
        protected DbSet<TEntity> DbSet { get; set; }

        public BaseRepository(AppDbContext appDbContext)
        {
            Context = appDbContext;
            DbSet = Context.Set<TEntity>();      
        }

        public async Task SaveChanges()
        {
            await Context.SaveChangesAsync();
        }

        public async Task<bool> Exist(Expression<Func<TEntity, bool>> filter)
        {
            return await DbSet.AnyAsync(filter);
        }

        public async Task<TEntity> GetById(int id)
        {
            return await DbSet.FirstAsync(x => x.Id == id);
        }

        public async Task<List <TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task Insert(TEntity entity)
        {
            await DbSet.AddAsync(entity);
        }

        public async Task Update(TEntity entity)
        {
            await Task.FromResult(() => DbSet.Update(entity));
        }

        public async Task Delete(TEntity entity)
        {
            await Task.FromResult(() => DbSet.Remove(entity));
        }
    }
}
