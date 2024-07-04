using Demo.Domain;
using Demo.Domain.Contracts.Repositories;
using Demo.Infra.Repository.Context;

namespace Demo.Infra.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DemoDBContext demoDbContext) : base(demoDbContext)
        {
        }
    }
}
