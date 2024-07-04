using Demo.Domain.Contracts.Repositories;
using Demo.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infra.Repository.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly DemoDBContext _demoDbContext;

        protected BaseRepository(DemoDBContext demoDbContext)
        {
            _demoDbContext = demoDbContext;
        }

        public Task<TEntity> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _demoDbContext.Set<TEntity>().ToListAsync();
        }

        public Task<TEntity?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
