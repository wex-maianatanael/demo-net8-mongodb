using Demo.Domain.Contracts.DomainServices;
using Demo.Domain.Contracts.Repositories;

namespace Demo.Domain.DomainServices
{
    public class BaseDomainService<TEntity> : IBaseDomainService<TEntity>
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseDomainService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
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
            return await _baseRepository.GetAllAsync();
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
