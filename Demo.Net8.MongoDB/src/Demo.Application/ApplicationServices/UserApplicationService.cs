using Demo.Application.Contracts;
using Demo.Domain;
using Demo.Domain.Contracts.DomainServices;

namespace Demo.Application.ApplicationServices
{
    public class UserApplicationService : IUserApplicationService
    {
        private readonly IUserDomainService _userDomainService;

        public UserApplicationService(IUserDomainService userDomainService)
        {
            _userDomainService = userDomainService;
        }

        public Task<User> CreateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _userDomainService.GetAllAsync();
        }

        public Task<User?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
