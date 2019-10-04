using Calendify.Domain.Users;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Interfaces.Persistence
{
    public interface IUserRepository: IRepository<User>
    {
        Result CheckDuplicateEmail(string email);
    }
}
