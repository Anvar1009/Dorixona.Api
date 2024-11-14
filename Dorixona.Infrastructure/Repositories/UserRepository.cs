using Dapper;
using Dorixona.Application.Abstractions.Data;
using Dorixona.Domain.Models.UserModel;
using Dorixona.Domain.Models.UserModel.UserRepository;

namespace Dorixona.Infrastructure.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext dbContext, ISqlConnection connection) : base(dbContext)
    {
    }
}
