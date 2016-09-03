using Core.Models;

namespace Core.Interfaces
{
    public interface IUserRepository
    {
        UserDomainModel GetByEmail(string email);
    }
}